using System.ComponentModel.DataAnnotations;

namespace Surf_Cafe.Models
{
    public enum DiscountType
    {
        Percent = 0,
        Fixed = 1
    }
    public class Discount
    {
        public int DiscountID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public DiscountType Type { get; set; }

        public int Value { get; set; }

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);
        public bool IsActive { get; set; } = false;
    }
}
