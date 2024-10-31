using FibertelData.Sources.BaseDeDatos;
using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelData.Store.Extentions;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Services;
using FibertelDomain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Services
{
    public class BannerServiceDbImpl : IBannerService
    {
        private readonly FibertelDbContext _db;

        public BannerServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR BANNER
        public Banner Create(Banner entity)
        {
            BannerTable bannerTable = entity.ToTable();
            _db.banners.Add(bannerTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idBanner = bannerTable.idBanner;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear el Banner");
            }
        }

        //ELIMINAR BANNER
        public void Delete(int id)
        {
            BannerTable? bannerTable = _db.banners.FirstOrDefault(r => r.idBanner == id);
            if (bannerTable == null) throw new MessageExeption("No se encontro el Banner");
            _db.banners.Remove(bannerTable);
            int result = _db.SaveChanges();
            if (result > 0)
                return;
            else
                throw new MessageExeption("No se pudo eliminar el Banner");
        }

        //LISTAR BANNER
        public List<Banner> GetAll()
        {
            List<Banner> list = _db.banners
                .Select<BannerTable, Banner>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //SELECCIONAR POR ID BANNER
        public Banner? GetById(int id)
        {
            BannerTable? banner = _db.banners
                .FirstOrDefault(r => r.idBanner == id);
            if (banner == null) return null;
            return banner.ToModel();
        }

        //ACTUALIZAR BANNER 
        public void Update(int id, Banner entity)
        {
            BannerTable? banner = _db.banners.FirstOrDefault(r => r.idBanner == id);
            if (banner == null) throw new MessageExeption("No se encontró el Banner");
            banner.imagen = entity.imagen;
            banner.enlace = entity.enlace;
            banner.estado = entity.estado;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo actualizar el Banner");
        }

    }
}
