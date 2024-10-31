using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelDomain.Store.Models
{
    public class Personal
    {
        public int idPersonal { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string rol { get; set; }
        public string contacto { get; set; }
        public string numeroDocumento { get; set; }
        public DateTime inicioOperacion { get; set; }
        public DateTime? finOperacion { get; set; }
    }

    public class PersonalBody
    {
        public int idPersonal { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string rol { get; set; }
        public string contacto { get; set; }
        public string numeroDocumento { get; set; }
        public DateTime inicioOperacion { get; set; }
        public DateTime? finOperacion { get; set; }

        public static implicit operator Personal(PersonalBody rb)
        {
            if (rb == null) return null;
            return new Personal
            {
                idPersonal = rb.idPersonal,
                nombres = rb.nombres,
                apellidos = rb.apellidos,
                rol = rb.rol,
                contacto = rb.contacto,
                numeroDocumento = rb.numeroDocumento,
                inicioOperacion = rb.inicioOperacion,
                finOperacion = rb.finOperacion
            };
        }
    }
}
