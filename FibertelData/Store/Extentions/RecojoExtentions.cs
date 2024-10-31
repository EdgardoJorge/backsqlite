using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class RecojoExtentions
    {
        public static Recojo ToModel(this RecojoTable rt)
        {
            return new Recojo
            {
                idRecojo = (int)rt.idRecojo,
                fechaListo = rt.fechaListo,
                fechaEntrega = rt.fechaEntrega,
                responsableDeRecojo = rt.responsableEntrega
            };
        }

        public static RecojoTable ToTable(this Recojo r)
        {
            return new RecojoTable
            {
                idRecojo = r.idRecojo,
                fechaListo = r.fechaListo,
                fechaEntrega = r.fechaEntrega,
                responsableEntrega = r.responsableDeRecojo,
            };
        }
    }
}
