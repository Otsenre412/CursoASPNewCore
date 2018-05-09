using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiAPI.Models;
using MiAPI.Models.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Todo")]
    public class TodoController : Controller
    {
        FakeTodoServices _service;
        public TodoController()
        {
            _service = new FakeTodoServices();
        }

        public IList<TodoList> GetLists()
        {
            return _service.GetTodoList();
        }
    }
}