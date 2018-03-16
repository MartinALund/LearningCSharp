using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Todo")]
    public class TodoController : Controller
    {
        private readonly TodoContext todoContext;

        public TodoController(TodoContext context)
        {
            todoContext = context;
            if (todoContext.TodoItems.Count() == 0)
            {
                todoContext.TodoItems.Add(new TodoItem { Name = "Vaske tøj" });
                todoContext.SaveChanges();
            }
        }

        [HttpGet]
        public List<TodoItem> GetAll()
        {
            return todoContext.TodoItems.ToList();
        }

        [HttpGet("{id}", Name ="GetTodo")]
        public IActionResult GetById(long id)
        {
            var item = todoContext.TodoItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            if (item == null) 
            {
                return BadRequest();
            }

            todoContext.TodoItems.Add(item);
            todoContext.SaveChanges();

            return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        }
    }
}