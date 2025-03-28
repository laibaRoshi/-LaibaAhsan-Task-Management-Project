using Microsoft.AspNetCore.Identity;

namespace TaskManagementSystem.Models
{
    public class User : IdentityUser
    {
        public ICollection<TaskItem>? Tasks { get; set; }
    }
}
