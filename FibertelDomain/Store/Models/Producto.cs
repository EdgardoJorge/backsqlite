

namespace FibertelDomain.Store.Models
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string productoNombre { get; set; }
        public decimal precio { get; set; }
        public decimal? precioOferta { get; set; }
        public int cantidad { get; set; }
        public string detalle { get; set; }
        public bool estado { get; set; }
        public string imagen01 { get; set; }
        public string imagen02 { get; set; }
        public string? imagen03 { get; set; }
        public string? imagen04 { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
    }

    public class ProductoBody
    {
        public string productoNombre { get; set; }
        public decimal precio { get; set; }
        public decimal? precioOferta { get; set; }
        public int cantidad { get; set; }
        public string detalle { get; set; }
        public bool estado { get; set; }
        public string imagen01 { get; set; }
        public string imagen02 { get; set; }
        public string? imagen03 { get; set; }
        public string? imagen04 { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }

        public static implicit operator Producto(ProductoBody rb)
        {
            if (rb == null) return null;
            return new Producto
            {
                idProducto = 0,
                productoNombre = rb.productoNombre,
                precio = rb.precio,
                precioOferta = rb.precioOferta,
                cantidad = rb.cantidad,
                detalle = rb.detalle,
                estado = rb.estado,
                imagen01 = rb.imagen01,
                imagen02 = rb.imagen02,
                imagen03 = rb.imagen03,
                imagen04 = rb.imagen04,
                idCategoria = rb.idCategoria,
                idMarca = rb.idMarca,
            };
        }
    }
}
