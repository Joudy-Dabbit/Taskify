using Microsoft.AspNetCore.Identity;

namespace Taskify.Models
{
    public class User : IdentityUser<Guid>
    { 
        public string Name { get; set; }
        public string? Url { get; set; }
    }
}