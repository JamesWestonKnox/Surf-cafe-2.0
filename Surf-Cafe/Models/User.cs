using System.ComponentModel.DataAnnotations;

namespace Surf_Cafe.Models
{
    public enum UserRole
    {
        Admin = 0,
        Staff = 1
    }
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        public UserRole Role { get; set; }

        [Required]
        public string PasscodeHash { get; set; }

        [Required]
        public DateTime DateRegistered { get; set; }
    }
}
