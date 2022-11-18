using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskify.Models;
using Taskify.Repository.Security.Main;

namespace Taskify.DataSource
{
    public class TaskifyContaxt : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        #region - constructor - 
        public TaskifyContaxt(DbContextOptions options) : base(options)
        {
        }
        #endregion
        public DbSet<Todo> Todos { get; set; }
    }
}
