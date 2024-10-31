using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class PedidoExtentions
    {
        public static Pedido ToModel(this PedidoTable rt)
        {
            return new Pedido
            {
                idPedido = rt.idPedido,
                fechaPedido = rt.fechaPedido,
                fechaCancelado = rt.fechaCancelado,
                tipoPedido = rt.tipoPedido,
                estado = rt.estado,
                total = rt.total,
                idCliente = rt.idCliente,
                idPersonal = rt.idPersonal,
                idEnvio = rt.idEnvio,
                idRecojo = rt.idRecojo
            };
        }

        public static PedidoTable ToTable(this Pedido r)
        {
            return new PedidoTable
            {
                idPedido = r.idPedido,
                fechaPedido = r.fechaPedido,
                fechaCancelado = r.fechaCancelado,
                tipoPedido = r.tipoPedido,
                estado = r.estado,
                total = r.total,
                idCliente = r.idCliente,
                idPersonal = r.idPersonal,
                idEnvio = r.idEnvio,
                idRecojo = r.idRecojo
            };
        } 
    }
}
