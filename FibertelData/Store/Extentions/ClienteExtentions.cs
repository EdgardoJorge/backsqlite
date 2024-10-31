using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class ClienteExtentions
    {
        public static Cliente ToModel(this ClienteTable rt)
        {
            return new Cliente
            {
                idCliente = rt.idCliente,
                razonSocial = rt.razonSocial,
                email = rt.email,
                telefonoMovil = rt.telefonoMovil,
                tipoDocumento = rt.tipoDocumento,
                numeroDocumento = rt.numeroDocumento,
                direccionFiscal = rt.direccionFiscal
            };
        }

        public static ClienteTable ToTable(this Cliente r)
        {
            return new ClienteTable
            {
                idCliente = r.idCliente,
                razonSocial = r.razonSocial,
                email = r.email,
                telefonoMovil = r.telefonoMovil,
                tipoDocumento = r.tipoDocumento,
                numeroDocumento = r.numeroDocumento,
                direccionFiscal = r.direccionFiscal
            };
        }
    }
}
