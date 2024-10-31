

namespace FibertelDomain.Store.Models
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string razonSocial { get; set; }
        public string email { get; set; }
        public string telefonoMovil  { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string direccionFiscal { get; set; }
    }

    public class ClienteBody 
    {
        public string razonSocial { get; set; }
        public string email { get; set; }
        public string telefonoMovil { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string direccionFiscal { get; set; }

    public static implicit operator Cliente(ClienteBody rb)
        {
            if (rb == null) return null;
            return new Cliente
            {
                idCliente = 0,
                razonSocial = rb.razonSocial,
                email = rb.email,
                telefonoMovil = rb.telefonoMovil,
                tipoDocumento = rb.tipoDocumento,
                numeroDocumento = rb.numeroDocumento,
                direccionFiscal = rb.direccionFiscal
            };
        }

    }
}
