using System.ComponentModel.DataAnnotations;

namespace Surf_Cafe.Models
{
    public enum ReportType
    {
        DailySales = 0,
        StockReport = 1
    }

    public class Report
    {
        public int ReportID { get; set; }

        [Required]
        public ReportType ReportType { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string FullPath { get; set; }

        [Required]
        public DateTime GeneratedDate { get; set; } = DateTime.Now;
    }
}
