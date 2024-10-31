using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class MarcaExtentions
    {
        public static Marca ToModel(this MarcaTable rt)
        {
            return new Marca
            {
                idMarca = rt.idMarca,
                marcaNombre = rt.marcaNombre,
                imagen = rt.imagen,
                estado = rt.estado,
            };
        }

        public static MarcaTable ToTable(this Marca r)
        {
            return new MarcaTable
            {
                 idMarca = r.idMarca,
                 marcaNombre = r.marcaNombre,
                 imagen = r.imagen,
                 estado = r.estado,
            };
        }
    }
}
