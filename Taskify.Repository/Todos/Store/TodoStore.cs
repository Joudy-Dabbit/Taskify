using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Taskify.DataTransferObjects.Todos;
using Taskify.Repository.Security.Main;

namespace Taskify.Repositories.Todos.Store
{
    public static class TodoStore
    {
        public static class Query
        {
            public static Expression<Func<Todo, GetTodoDto>> GetAllTodo => t
                => new GetTodoDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    Color = t.Color,
                    Date = t.Date,
                    Description = t.Description,
                    Priority = t.Priority,
                    Status = t.Status,
                    Type = t.Type
                };

            public static Action<ModifyTodoDto, Todo> ModifyTodo = (dto, todo) =>
            {
                todo.Name = dto.Name;
                todo.Color = dto.Color;
                todo.Date = dto.Date;
                todo.Description = dto.Description;
                todo.Priority = dto.Priority;
                todo.Status = dto.Status;
                todo.Type = dto.Type;
            };
        }    
        
        public static class Filter
        {

        }
    }
}
