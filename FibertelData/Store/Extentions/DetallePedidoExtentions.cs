using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class DetallePedidoExtentions
    {
        public static DetallePedido ToModel(this DetallePedidoTable rt)
        {
            return new DetallePedido
            {
                idDetallePedido = rt.idDetallePedido,
                cantidad = rt.cantidad,
                precioUnitario = rt.precioUnitario,
                precioDescuento = (decimal)rt.precioDescuento,
                subtotal = rt.subTotal,
                idProducto = rt.idProducto,
                idPedido = rt.idPedido
            };  
        }

        public static DetallePedidoTable ToTable(this DetallePedido r)
        {
            return new DetallePedidoTable
            {
                idDetallePedido = r.idDetallePedido,
                cantidad = r.cantidad,
                precioUnitario = r.precioUnitario,
                precioDescuento = r.precioDescuento,
                subTotal = r.subtotal,
                idProducto = r.idProducto,
                idPedido = r.idPedido
            };
        }
    }
}
