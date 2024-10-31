using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("administradors", Schema = "Tienda")]
    public class AdministradorTable
    {
        [Key]
        public int idAdministrador { get; set; }
        [Required]
        [StringLength(100)]
        public string nombres { get; set; }
        [Required]
        [StringLength(20)]
        public string telefonoMovil { get; set; }
        [Required]
        public bool estado { get; set; }
        [Required]
        [StringLength(50)]
        public string email { get; set; }
        [Required]
        [StringLength(30)]
        public string password { get; set; }
        
        
    }
}
