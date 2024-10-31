using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelDomain.Store.Models
{
    public class DetallePedido
    {
        public int idDetallePedido { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal precioDescuento { get; set; }
        public decimal subtotal { get; set; }
        public int idProducto { get; set; }
        public int idPedido { get; set; }
    }

    public class DetallePedidoBody
    {
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal precioDescuento { get; set; }
        public decimal subtotal { get; set; }
        public int idProducto { get; set; }
        public int idPedido { get; set; }

        public static implicit operator DetallePedido(DetallePedidoBody rb)
        {
            if (rb == null) return null;
            return new DetallePedido
            {
                idDetallePedido = 0,
                cantidad = rb.cantidad,
                precioUnitario = rb.precioUnitario,
                precioDescuento = rb.precioDescuento,
                subtotal = rb.subtotal,
                idProducto = rb.idProducto,
                idPedido = rb.idPedido
            };
        }
    }

}
