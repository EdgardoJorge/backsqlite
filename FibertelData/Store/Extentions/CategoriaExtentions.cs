using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class CategoriaExtentions
    {
        public static Categoria ToModel(this CategoriaTable rt)
        {
            return new Categoria
            {
                idCategoria = rt.idCategoria,
                categoriaNombre = rt.categoriaNombre,
                imagen = rt.imagen,
                estado = rt.estado,
            };
        }

        public static CategoriaTable ToTable(this Categoria r)
        {
            return new CategoriaTable
            {
                idCategoria = r.idCategoria,
                categoriaNombre = r.categoriaNombre,
                imagen = r.imagen,
                estado = r.estado,
            };
        }
    }
}
