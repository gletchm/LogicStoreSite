using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace LogicStoreAPI.Models
{
    public class StoreItem
    {
        [Key]
        public int ItemID { get; set; }

        [StringLength(100)]
        public string ItemTitle { get; set; } = string.Empty;

        public ItemCondition Condition { get; set; } = 0;

        public float ItemPrice { get; set; } = 0;

        public float ItemCost { get; set; } = 0;

        [StringLength(2048)]
        public string ItemDescription { get; set; } = string.Empty;

        [Column(TypeName = "varchar(MAX)")]
        [MaxLength]
        public string ItemPicture { get; set; } = string.Empty;

        public int InStock { get; set; } = 0;

        [StringLength(20)]
        public string ItemSKU { get; set;} = string.Empty;

        public float ItemWeight { get; set; } = 0;

    }
}
