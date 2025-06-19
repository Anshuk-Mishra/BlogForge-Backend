using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Users
    {
        [Required]
        [Key]
        public string UID { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PassHash { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        
        [Required]
        public string PhraseHash { get; set; } = string.Empty;

        public DateTime Dob { get; set; }
    }

}
