

namespace FibertelDomain.Store.Models
{
    public class Comprobante
    {
        public int idComprobante { get; set; }
        public string tipoComprobante { get; set; }
        public DateTime fechaEmision { get; set; }
        public int idPedido { get; set; }
    }

    public class ComprobanteBody
    {
        public string tipoComprobante { get; set; }
        public DateTime fechaEmision { get; set; }
        public int idPedido { get; set; }

        public static implicit operator Comprobante(ComprobanteBody rb)
        {
            if (rb == null) return null;
            return new Comprobante
            {
                idComprobante = 0,
                tipoComprobante = rb.tipoComprobante,
                fechaEmision = rb.fechaEmision,
                idPedido = rb.idPedido
            };
        }
    }
}
