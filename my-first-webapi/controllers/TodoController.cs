using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_first_webapi.models;
using my_first_webapi.services;

namespace my_first_webapi.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("getWorkTasks")]

        public List<TodoItemDTO> GetAllWorkTaskAsync()
        {
            return _todoService.GetTodoItems();
        }
    }
}