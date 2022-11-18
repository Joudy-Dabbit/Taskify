using Meteors;
using Microsoft.AspNetCore.Mvc;
using Taskify.DataTransferObjects.Todos;
using Taskify.Repositories.Todos;

namespace Taskify.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

        public class TodoController : ControllerBase
        {
            private readonly ITodoRepository repository;

            public TodoController(ITodoRepository countryRepository)
            {
                repository = countryRepository;
            }

        [HttpGet]
        public async Task<IActionResult> GetAll() => await repository.GetAll().ToJsonResultAsync();

        [HttpGet]
        public async Task<IActionResult> GetById(Guid id) => await repository.GetById(id).ToJsonResultAsync();

        [HttpPost]
        public async Task<IActionResult> Add(AddTodoDto dto) => await repository.Add(dto).ToJsonResultAsync();

        [HttpPost]
        public async Task<IActionResult> Modify(ModifyTodoDto dto) => await repository.Modify(dto).ToJsonResultAsync();

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id) => await repository.Delete(id).ToJsonResultAsync();
    }
}
