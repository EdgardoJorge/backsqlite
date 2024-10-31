using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelDomain.Store.Models
{
    public class Recojo
    {
        public int idRecojo { get; set; }
        public DateTime? fechaListo { get; set; }
        public DateTime? fechaEntrega { get; set; }
        public string? responsableDeRecojo { get; set; }
    }

    public class RecojoBody
    {
        public DateTime? fechaListo { get; set; }
        public DateTime? fechaEntrega { get; set; }
        public string? responsableDeRecojo { get; set; }

        public static implicit operator Recojo(RecojoBody rb)
        {
            if (rb == null) return null;
            return new Recojo
            {
                idRecojo = 0,
                fechaListo = rb.fechaListo,
                fechaEntrega = rb.fechaEntrega,
                responsableDeRecojo = rb.responsableDeRecojo
            };
        }
    }
}
