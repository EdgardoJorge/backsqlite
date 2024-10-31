
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FibertelData.Sources.BaseDeDatos.Tables
{
    [Table("detallePedidos", Schema = "Movimientos")]
    public class DetallePedidoTable
    {
        [Key]
        public int idDetallePedido { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        [Precision(6, 2)]
        public decimal precioUnitario { get; set; }
        [Precision(6, 2)]
        public decimal? precioDescuento { get; set; }
        [Required]
        [Precision(6, 2)]
        public decimal subTotal { get; set; }
        [Required]
        public int idProducto { get; set; }
        [Required]
        public int idPedido { get; set; }

        public ProductoTable Producto { get; set; }
        public PedidoTable Pedido { get; set; }
    }
}
