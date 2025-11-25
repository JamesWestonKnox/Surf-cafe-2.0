using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surf_Cafe.Models
{
    public class Tip
    {
        public int TipID { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TipAmount { get; set; } = decimal.Zero;

        [Required]
        public DateTime TipDateTime { get; set; } = DateTime.Now;

        [Required]
        public int PaymentID { get; set; }
        [ForeignKey("PaymentID")]
        public Payment Payment { get; set; }
    }
}
