using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskify.ShearedKernel.Enum;

namespace Taskify.DataTransferObjects.Todos
{
    public class GetByIdTodoDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public TodoType Type { get; set; }
        public TodoStatus Status { get; set; }
        public TodoPriority Priority { get; set; }    
        public DateTime Date { get; set; }
    }
}
