using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surf_Cafe.Models
{
    public enum PaymentType
    {
        Cash,
        Card,
        EFT
    }
    public class Payment
    {
        public int PaymentID { get; set; }

        [Required]
        public PaymentType Type { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaymentAmount { get; set; } = decimal.Zero;

        [Required]
        public DateTime PaymentDateTime { get; set; } = DateTime.Now;

        [Required]
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }
    }
}
