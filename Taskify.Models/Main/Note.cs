using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskify.Models.Main
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; } 
        public string? Url { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
    }
}
