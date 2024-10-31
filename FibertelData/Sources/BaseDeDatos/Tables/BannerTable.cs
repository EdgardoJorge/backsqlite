
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("banners", Schema = "Tienda")]
    public class BannerTable
    {
        [Key]
        public int idBanner { get; set; }
        [Required]
        [StringLength(300)]
        public string imagen { get; set; }
        [Required]
        [StringLength(300)]
        public string enlace { get; set; }
        [Required]
        public bool estado { get; set; }
    }
}
