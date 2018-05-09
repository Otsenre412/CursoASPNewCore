using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAPI.Models.Servicios
{
    public class FakeTodoServices
    {
        public FakeTodoServices() { }

        public IList<TodoList> GetTodoList()
        {
            var lista1 = new TodoList()
            {
                Id = 1,
                Name = "Lita de la compra",
                Owner = "Ernesto",
                Items = new List<TodoItem>()
                {
                    new TodoItem(){ TodoListId=1, Description= " Huevos"},
                    new TodoItem(){ TodoListId=1, Description= " Pan"},
                    new TodoItem(){ TodoListId=1, Description= " Platanos"},
                    new TodoItem(){ TodoListId=1, Description= " Carne"},
                }
            };

            var listCollection = new List<TodoList>
            {
                lista1
            };
            return listCollection;
        }
    }
}
