using Meteors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskify.DataTransferObjects.Todos;
using Taskify.Repository.Security.Main;

namespace Taskify.Repositories.Todos
{
    public interface ITodoRepository
    {
        Task<OperationResult<List<GetTodoDto>>> GetAll();
        Task<OperationResult<GetTodoDto>> GetById(Guid id);
        Task<OperationResult<GetTodoDto>> Add(AddTodoDto dto);
        Task<OperationResult<GetTodoDto>> Modify(ModifyTodoDto dto);
        Task<OperationResult<bool>> Delete(Guid id);
    }
}
