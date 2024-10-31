using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class AdministardorExtentions
    {
        public static Administrador ToModel(this AdministradorTable rt)
        {
            return new Administrador
            {
                idAdministrador = rt.idAdministrador,
                nombres = rt.nombres,
                telefonoMovil = rt.telefonoMovil,
                estado = rt.estado,
                email = rt.email,
                password = rt.password,
            };
        }

        public static AdministradorTable ToTable(this Administrador r)
        {
            return new AdministradorTable
            {
                idAdministrador = r.idAdministrador,
                nombres = r.nombres,
                telefonoMovil = r.telefonoMovil,
                estado = r.estado,
                email = r.email,
                password = r.password,
            };
        }
    }
    
}
