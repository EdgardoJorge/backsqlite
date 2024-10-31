using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelDomain.Store.Models
{
    public class Envio
    {
        public int idEnvio { get; set; }
        public string  region { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public string localidad { get; set; }
        public  string calle {  get; set; }
        public string nDomicilio { get; set; }
        public string codigoPostal { get; set; }
        public DateTime? fechaEnvio { get; set; }
        public DateTime? fechaEntrega { get; set; }
        public string? responsableEntrega { get; set; }
        public int? idPersonal { get; set; }
    }

    public class EnvioBody
    {
        public string region { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public string localidad { get; set; }
        public string calle { get; set; }
        public string nDomicilio { get; set; }
        public string codigoPostal { get; set; }
        public DateTime? fechaEnvio { get; set; }
        public DateTime? fechaEntrega { get; set; }
        public string? responsableEntrega { get; set; }
        public int? idPersonal { get; set; }

        public static implicit operator Envio(EnvioBody rb)
        {
            if (rb == null) return null;
            return new Envio
            {
                idEnvio = 0,
                region = rb.region,
                provincia = rb.provincia,
                distrito = rb.distrito,
                localidad = rb.localidad,
                calle = rb.calle,
                nDomicilio = rb.nDomicilio,
                codigoPostal = rb.codigoPostal,
                fechaEnvio = rb.fechaEnvio,
                fechaEntrega = rb.fechaEntrega,
                responsableEntrega = rb.responsableEntrega,
                idPersonal = rb.idPersonal
            };
        }
    }
    
}
