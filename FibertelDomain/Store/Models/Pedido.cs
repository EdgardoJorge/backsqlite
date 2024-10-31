using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelDomain.Store.Models
{
    public class Pedido
    {
        public int idPedido { get; set; } 
        public DateTime fechaPedido { get; set; }
        public DateTime? fechaCancelado { get; set; }
        public string tipoPedido { get; set; }
        public string estado { get; set; }
        public decimal total { get; set; }
        public int idCliente { get; set; }
        public int? idPersonal { get; set; }
        public int? idEnvio { get; set; }
        public int? idRecojo { get; set; }
    }

    public class PedidoBody
    {
        public DateTime fechaPedido { get; set; }
        public DateTime? fechaCancelado { get; set; }
        public string tipoPedido { get; set; }
        public string estado { get; set; }
        public decimal total { get; set; }
        public int idCliente { get; set; }
        public int? idPersonal { get; set; }
        public int? idEnvio { get; set; }
        public int? idRecojo { get; set; }

        public static implicit operator Pedido(PedidoBody rb)
        {
            if (rb == null) return null;
            return new Pedido
            {
                idPedido = 0,
                fechaPedido = rb.fechaPedido,
                fechaCancelado = rb.fechaCancelado,
                tipoPedido = rb.tipoPedido,
                estado = rb.estado,
                total = rb.total,
                idCliente = rb.idCliente,
                idPersonal = rb.idPersonal,
                idEnvio = rb.idEnvio,
                idRecojo = rb.idRecojo,
            };
        }
    }

}
