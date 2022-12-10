using System.ComponentModel.DataAnnotations;

namespace ReadyList.Database.Models
{
    public class Issue
    {
        public Guid IssueId { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Title { get; set; }

        public bool IsDone { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? Time { get; set; }

        public User[]? AssociatedUsers { get; set; }

        [MaxLength(150)]
        public string? Description { get; set; }
    }
}
