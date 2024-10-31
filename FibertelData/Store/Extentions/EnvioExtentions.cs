using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class EnvioExtentions
    {
        public static Envio ToModel(this EnvioTable rt)
        {
            return new Envio
            {
                idEnvio = rt.idEnvio,
                region = rt.region,
                provincia = rt.provincia,
                distrito = rt.distrito,
                localidad = rt.localidad,
                calle = rt.calle,
                nDomicilio = rt.nDomicilio,
                codigoPostal = rt.codigoPostal,
                fechaEnvio = rt.fechaEnvio,
                fechaEntrega = rt.fechaEntrega,
                responsableEntrega = rt.responsableEntrega,
                idPersonal = rt.idPersonal
            };
        }

        public static EnvioTable ToTable(this Envio r)
        {
            return new EnvioTable
            {
                idEnvio = r.idEnvio,
                region = r.region,
                provincia = r.provincia,
                distrito = r.distrito,
                localidad = r.localidad,
                calle = r.calle,
                nDomicilio = r.nDomicilio,
                codigoPostal = r.codigoPostal,
                fechaEnvio = r.fechaEnvio,
                fechaEntrega = r.fechaEntrega,
                responsableEntrega = r.responsableEntrega,
                idPersonal = r.idPersonal,
            };
        }
    }
}
