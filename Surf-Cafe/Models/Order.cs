using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surf_Cafe.Models
{
    public enum OrderStatus
    {
        Opened = 0,
        Closed = 1
    }
    public class Order
    {
        public int OrderID { get; set; }

        [Required]
        [MaxLength(100)]
        public string OrderName { get; set; }

        [Required]
        public DateTime OrderDateTime { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderTotal { get; set; } = decimal.Zero;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal VATAmount { get; set; } = decimal.Zero;

        [Required]
        public OrderStatus Status { get; set; }

        [Required]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }

        public int? CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        public int? DiscountID { get; set; }
        [ForeignKey("DiscountID")]
        public Discount Discount { get; set; }

    }
}
