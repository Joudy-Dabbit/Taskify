using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskify.Models.Base;
using Taskify.ShearedKernel.Enum;
namespace Taskify.Repository.Security.Main
{
    public class Todo : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public TodoType Type { get; set; }
        public TodoStatus Status { get; set; }
        public TodoPriority Priority { get; set; }

        /// <summary>
        /// This property to set the date on which the todo should begin
        /// </summary>        
        public DateTime Date { get; set; }
    }
}
