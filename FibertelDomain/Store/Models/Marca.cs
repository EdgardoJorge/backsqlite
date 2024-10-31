using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelDomain.Store.Models
{
    public class Marca
    {
        public int idMarca { get; set; }
        public string marcaNombre { get; set; }
        public string imagen { get; set; }
        public bool estado { get; set; }

    }

    public class MarcaBody
    {
        public string marcaNombre { get; set; }
        public string imagen { get; set; }
        public bool estado { get; set; }

        public static implicit operator Marca(MarcaBody rb)
        {
            if (rb == null) return null;
            return new Marca
            {
                idMarca = 0,
                marcaNombre = rb.marcaNombre,
                imagen = rb.imagen,
                estado = rb.estado
            };
        }
    }
}
