using System.ComponentModel.DataAnnotations;

namespace Surf_Cafe.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public int LoyaltyPoints { get; set; } = 0;

        [Required]
        public DateTime DateRegistered { get; set; } = DateTime.Now;

    }
}
