using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelDomain.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Extentions
{
    public static class BannerExtentions
    {
        public static Banner ToModel(this BannerTable rt)
        {
            return new Banner
            {
                idBanner = rt.idBanner,
                imagen = rt.imagen,
                enlace = rt.enlace,
                estado = rt.estado
            };
        }

        public static BannerTable ToTable(this Banner r)
        {
            return new BannerTable
            {
                idBanner = r.idBanner,
                imagen = r.imagen,
                enlace = r.enlace,
                estado = r.estado
            };
        }
    }
}
