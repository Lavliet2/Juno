namespace SharedModel.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public Guid UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime? LastLogin { get; set; }
        public ICollection<string> GroupIds { get; set; }
    }
}
