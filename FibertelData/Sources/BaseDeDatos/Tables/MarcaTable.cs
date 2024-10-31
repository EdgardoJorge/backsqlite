
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("marcas", Schema = "Tienda")]
    public class MarcaTable
    {
        [Key]
        public int idMarca { get; set; }
        [Required]
        [StringLength(30)]
        public string marcaNombre { get; set; }
        [Required]
        [StringLength(300)]
        public string imagen { get; set; }
        [Required]
        public bool estado { get; set; }
    }
}
