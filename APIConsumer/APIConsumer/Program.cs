﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace APIConsumer
{
    class Program
    {
        public static IConfiguration Configuration { get; set; }
        static HttpClient client = new HttpClient();

        static void Main ( string [] args)
        {

            var builder = new ConfigurationBuilder()

                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            Console.WriteLine(Configuration["applicationName"]);


            Console.ReadKey();

            RunAsync().GetAwaiter().GetResult();
            Console.ReadKey();
        }

        static async Task RunAsync()
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49959/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("http://localhost:49959/"));

            var todoApi = "api/todo";
            var lists = GetTodoListsAsync(todoApi);

            var newlist = new TodoList()
            {
                Name = "Lista creada desde el cliente",
                Owner = "Ernesto"
            };

            var uri = await CreateTodoListAsync(newlist, todoApi);
            Console.WriteLine(uri);
            Console.ReadKey();

        }

        private static async Task CreateTodoListAsync(TodoList list, string uri)
        {
            var dataString = JsonConvert.SerializeObject(list);
            var content = new StringContent(dataString);
            content.Headers.ContentType = new MediaTypeHeaderValue("aplication/json");

            HttpResponseMessage response = await client.PostAsync(uri, content);
            response.EnsureSuccessStatusCode();

            return Response.Headers.location;
        }

        private static async Task<List<TodoList>> GetTodoListsAsync(string path)
        {
            string result = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }
            var a = JsonConvert.DeserializeObject<List<TodoList>>(result);
            return a;
        }
    }
}
