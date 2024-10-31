using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("productos", Schema = "Tienda")]
    public class ProductoTable
    {
        [Key]
        public int idProducto { get; set; }
        [Required]
        [StringLength(150)]
        public string productoNombre { get; set; }
        [Required]
        [Precision(6, 2)]
        public decimal precio { get; set; }
        [Precision(6, 2)]
        public decimal? precioOferta { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        [StringLength(5000)]
        public string detalle { get; set; }
        [Required]
        public bool estado { get; set; }
        [Required]
        [StringLength(300)]
        public string imagen01 { get; set; }
        [Required]
        [StringLength(300)]
        public string imagen02 { get; set; }
        [StringLength(300)]
        public string? imagen03 { get; set; }
        [StringLength(300)]
        public string? imagen04 { get; set; }
        [Required]
        public int idCategoria { get; set; }
        [Required]
        public int idMarca { get; set; }

        public ICollection<DetallePedidoTable> DetallePedidos { get; set; }

    }
}
