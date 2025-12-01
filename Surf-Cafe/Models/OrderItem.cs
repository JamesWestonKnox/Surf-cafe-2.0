using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surf_Cafe.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        [Required]
        public int Quantity { get; set; } = 0;

        [MaxLength(300)]
        public string? ItemNotes { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ItemSubTotal { get; set; } = decimal.Zero;

        [Required]
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [Required]
        public int MenuItemID { get; set; }
        [ForeignKey("MenuItemID")]
        public MenuItem MenuItem { get; set; }
    }
}
