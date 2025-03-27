using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Models
{
    public class TaskItem
    {
        [Key] 
        public int Id { get; set; }  // Primary Key

        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; } = "Medium";
        public bool IsCompleted { get; set; } = false;

        // Foreign Key to IdentityUser
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
