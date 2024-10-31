
using System.ComponentModel.DataAnnotations;

namespace FibertelDomain.Store.Models
{
    public class Banner
    {
        public int idBanner { get; set; }
        public string imagen { get; set; }
        public string enlace { get; set; }
        public bool estado { get; set; }
    }

    public class BannerBody
    {
        public string imagen { get; set; }
        public string enlace { get; set; }
        public bool estado { get; set; }

        public static implicit operator Banner(BannerBody rb)
        {
            if (rb == null) return null;
            return new Banner
            {
                idBanner = 0,
                imagen = rb.imagen,
                enlace = rb.enlace,
                estado = rb.estado,
            };

        }
    }
}
