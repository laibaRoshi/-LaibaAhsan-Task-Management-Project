using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TaskManagementSystem.Models
{
    public class TaskItem
    {
        [Key] // Primary key annotation
        public int Id { get; set; }  // ✅ Define Primary Key

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public string Priority { get; set; } = "Medium";

        public bool IsCompleted { get; set; } = false;

        // Foreign key to IdentityUser (AspNetUsers)
        [ForeignKey("User")]
        public string? UserId { get; set; }  // Change from int to string

        public IdentityUser? User { get; set; } // Use IdentityUser from Identity
    }
}
