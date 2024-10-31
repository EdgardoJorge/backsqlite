
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("categorias", Schema = "Tienda")]
    public class CategoriaTable
    {
        [Key]
        public int idCategoria { get; set; }
        [Required]
        [StringLength(30)]
        public string categoriaNombre { get; set; }
        [Required]
        [StringLength(300)]
        public string imagen { get; set; }
        [Required]
        public bool estado { get; set; }
    }
}
