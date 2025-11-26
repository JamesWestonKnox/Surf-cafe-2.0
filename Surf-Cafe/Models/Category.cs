using System.ComponentModel.DataAnnotations;

namespace Surf_Cafe.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }
    }
}
