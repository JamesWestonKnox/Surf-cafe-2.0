using System.ComponentModel.DataAnnotations;

namespace Surf_Cafe.Models
{
    public class StockItem
    {
        public int StockItemID { get; set; }

        [Required]
        [MaxLength(100)]
        public string StockItemName { get; set; }

        [Required]
        public int StartOfDayQuantity { get; set; } = 0;

        [Required]
        public int EndOfDayQuantity { get; set; } = 0;

        [Required]
        [MaxLength(50)]
        public string Unit { get; set; }

        [Required]
        public int Threshold { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; } = DateTime.Now;

    }
}
