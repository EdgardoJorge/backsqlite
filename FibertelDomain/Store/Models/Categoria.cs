using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelDomain.Store.Models
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string categoriaNombre { get; set; }
        public string imagen { get; set; }
        public bool estado { get; set; }
    }

    public class CategoriaBody
    {
        public string categoriaNombre { get; set; }
        public string imagen { get; set; }
        public bool estado { get; set; }

        public static implicit operator Categoria(CategoriaBody rb)
        {
            if (rb == null) return null;
            return new Categoria
            {
                idCategoria = 0,
                categoriaNombre = rb.categoriaNombre,
                imagen = rb.imagen,
                estado = rb.estado
            };
        }
    }
}
