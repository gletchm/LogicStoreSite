using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LogicStoreAPI.Models
{
    public class ItemPicture
    {
        [Key]
        public int PictureId { get; set; }

        public int ItemID { get; set; }

        public int SortOrder { get; set; } = 0;

        [Column(TypeName = "varchar(MAX)")]
        [MaxLength]
        public string PictureString { get; set; } = string.Empty;
    }
}
