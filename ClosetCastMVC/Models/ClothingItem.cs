using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClosetCastMVC.Models
{
    public class ClothingItem
    {

        [Key]
        public int ClothingItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Top, Bottom, Outerwear, Shoes or Accessory
        public string Category { get; set; }

        // 1 = very light (hot days) up to 5 = very warm (freezing days)
        [DisplayName("Warmth Level")]
        [Range(1, 5)]
        public int WarmthLevel { get; set; }

        [DisplayName("Waterproof")]
        public bool IsWaterproof { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Purchased")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DatePurchased { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
    }
}
