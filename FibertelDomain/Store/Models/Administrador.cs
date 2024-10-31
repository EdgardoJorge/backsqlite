using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelDomain.Store.Models
{
    public class Administrador
    {
        public int idAdministrador { get; set; }
        public string nombres { get; set; }
        public string telefonoMovil { get; set; }
        public bool estado { get; set; }
        public string email { get; set; }
        public string password { get; set; }


    }

    public class AdministradorBody
    {
        public string nombres { get; set; }
        public string telefonoMovil { get; set; }
        public bool estado { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public static implicit operator Administrador(AdministradorBody rb)
        {
            if (rb == null) return null;
            return new Administrador
            {
                idAdministrador = 0,
                nombres = rb.nombres,
                telefonoMovil = rb.telefonoMovil,
                estado = rb.estado,
                email = rb.email,
                password = rb.password

            };
        }


    }
}
