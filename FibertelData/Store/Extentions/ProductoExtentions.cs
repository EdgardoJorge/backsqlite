using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class ProductoExtentions
    {
        public static Producto ToModel(this ProductoTable rt)
        {
            return new Producto
            {
                idProducto = rt.idProducto,
                productoNombre = rt.productoNombre,
                precio = rt.precio,
                precioOferta = rt.precioOferta ?? 0.0m,
                cantidad = rt.cantidad,
                detalle = rt.detalle,
                estado = rt.estado,
                imagen01 = rt.imagen01,
                imagen02 = rt.imagen02,
                imagen03 = rt.imagen03 ?? "",
                imagen04 = rt.imagen04 ?? "",
                idCategoria = rt.idCategoria,
                idMarca = rt.idMarca,
            };
        }

        public static ProductoTable ToTable(this Producto r)
        {
            return new ProductoTable
            {
                idProducto = r.idProducto,
                productoNombre = r.productoNombre,
                precio = r.precio,
                precioOferta = r.precioOferta,
                cantidad = r.cantidad,
                detalle = r.detalle,
                estado = r.estado,
                imagen01 = r.imagen01,
                imagen02 = r.imagen02,
                imagen03 = r.imagen03,
                imagen04 = r.imagen04,
                idCategoria = r.idCategoria,
                idMarca = r.idMarca,
            };
        } 
    }
}
