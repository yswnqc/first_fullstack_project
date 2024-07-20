using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using my_first_webapi.data;
using my_first_webapi.models;

namespace my_first_webapi.services
{
    public class TodoService
    {
        private readonly TodoAppDbContext _dbContext;

        public TodoService(TodoAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TodoItemDTO> GetTodoItems()
        {
            return _dbContext.TodoItems
            .Select(X => new TodoItemDTO {
                Title = X.Title,
                IsDone = X.IsDone
            }).ToList();
        }
    }
}