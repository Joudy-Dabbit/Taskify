using Meteors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskify.DataSource;

namespace Taskify.Repositories.Base
{
    public class BaseRepository
    {
        public TaskifyContext Context { get; set; }

        public BaseRepository(TaskifyContext context)
        {
            Context = context;
        }
    }
}
