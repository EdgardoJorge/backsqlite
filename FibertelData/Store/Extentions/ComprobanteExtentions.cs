using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class ComprobanteExtentions
    {
        public static Comprobante ToModel(this ComprobanteTable rt)
        {
            return new Comprobante
            {
                idComprobante = rt.idComprobante,
                tipoComprobante = rt.tipoComprobante,
                fechaEmision = rt.fechaEmision,
                idPedido = rt.idPedido,
            };
        }

        public static ComprobanteTable ToTable(this Comprobante r)
        {
            return new ComprobanteTable
            {
                idComprobante = r.idComprobante,
                tipoComprobante = r.tipoComprobante,
                fechaEmision = r.fechaEmision,
                idPedido = r.idPedido,
            };
        }
    }
}
