using System.ComponentModel.DataAnnotations;
namespace BrainFart.Models
{
    public class Whiteboard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string OwnerId { get; set; }  // Links to the Owner (user who created it)

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string? BoardData { get; set; }
    }
}
