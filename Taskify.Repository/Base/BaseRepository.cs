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
        public TaskifyContaxt Context { get; set; }

        public BaseRepository(TaskifyContaxt context)
        {
            Context = context;
        }
    }
}
