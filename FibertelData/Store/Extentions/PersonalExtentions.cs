using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class PersonalExtentions
    {
        public static Personal ToModel(this PersonalTable rt)
        {
            return new Personal
            {
                idPersonal = rt.idPersonal,
                nombres = rt.nombres,
                apellidos = rt.apellidos,
                rol = rt.rol,
                contacto = rt.contacto,
                numeroDocumento = rt.numeroDocumento,
                inicioOperacion = rt.inicioOperacion,
                finOperacion = rt.finOperacion
            };
        }

        public static PersonalTable ToTable(this Personal r)
        {
            return new PersonalTable
            {
                idPersonal = r.idPersonal,
                nombres = r.nombres,
                apellidos = r.apellidos,
                rol = r.rol,
                contacto = r.contacto,
                numeroDocumento = r.numeroDocumento,
                inicioOperacion = r.inicioOperacion,
                finOperacion = r.finOperacion,
            };
        }
    }
}
