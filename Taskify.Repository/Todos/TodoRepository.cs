using Meteors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskify.DataSource;
using Taskify.DataTransferObjects.Todos;
using Taskify.Repositories.Base;
using Taskify.Repositories.Todos.Store;
using Taskify.Repository.Security.Main;

namespace Taskify.Repositories.Todos
{
    public class TodoRepository :  BaseRepository, ITodoRepository
    {
        public TodoRepository(TaskifyContaxt context) : base(context)  {  }

        public async Task<OperationResult<List<GetTodoDto>>> GetAll()
        {
            var todos = await Context.Todos.Select(TodoStore.Query.GetAllTodo).ToListAsync();

            return _Operation.SetSuccess(todos);
        }
        public async Task<OperationResult<GetTodoDto>> GetById(Guid id)
        {
            var todo = await Context.Todos.Where(t => t.Id == id)
                                           .Select(TodoStore.Query.GetAllTodo)
                                           .FirstAsync();

            return _Operation.SetSuccess(todo);
        }
        public async Task<OperationResult<GetTodoDto>> Add(AddTodoDto dto)
        {  
            var todo = new Todo()
            {
                Date = dto.Date,
                Description = dto.Description,
                Name = dto.Name,
                Priority = dto.Priority,
                Color = dto.Color,
                Status = dto.Status,
                Type = dto.Type,
            };
            Context.Add(todo);
            await Context.SaveChangesAsync();

            return await GetById(todo.Id);
        }
        public async Task<OperationResult<GetTodoDto>> Modify(ModifyTodoDto dto)
        {
            var todo = await Context.Todos.Where(t => t.Id == dto.Id).FirstAsync();

            TodoStore.Query.ModifyTodo(dto, todo);
            await Context.SaveChangesAsync();

            return await GetById(todo.Id);
        }
        public async Task<OperationResult<bool>> Delete(Guid id)
        {
            var todo = await Context.Todos.Where(t => t.Id == id).FirstAsync();

            todo.DateDeleted = DateTime.UtcNow;
            await Context.SaveChangesAsync();
            return _Operation.SetSuccess(true);
        }
    }
}
