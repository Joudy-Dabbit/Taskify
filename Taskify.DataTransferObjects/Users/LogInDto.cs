using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskify.DataTransferObjects
{
    public class LogInDto
    {
        [DefaultValue("SuperAdmin")]
        public string UserName { get; set; }

        [DefaultValue("1234")]
        public string Password { get; set; }
    }
}
