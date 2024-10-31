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
    public class RecojoServiceDbImpl : IRecojoService
    {
        private readonly FibertelDbContext _db;

        public RecojoServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR RECOJO
        public Recojo Create(Recojo entity)
        {
            RecojoTable recojoTable = entity.ToTable();
            _db.recojos.Add(recojoTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idRecojo = (int)recojoTable.idRecojo;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear el Recojo");
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        //LISTAR RECOJOS
        public List<Recojo> GetAll()
        {
            List<Recojo> list = _db.recojos
                .Select<RecojoTable, Recojo>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //SELECCIONAR POR ID RECOJO
        public Recojo? GetById(int id)
        {
            RecojoTable? recojo = _db.recojos
                .FirstOrDefault(r => r.idRecojo == id);
            if (recojo == null) return null;
            return recojo.ToModel();
        }

        //ACTUALIZAR RECOJO 
        public void Update(int id, Recojo entity)
        {
            RecojoTable? recojo = _db.recojos.FirstOrDefault(r => r.idRecojo == id);
            if (recojo == null) throw new MessageExeption("No se encontró el Recojo");
            recojo.fechaListo = entity.fechaListo;
            recojo.fechaEntrega = entity.fechaEntrega;
            recojo.responsableEntrega = entity.responsableDeRecojo;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo actualizar el Recojo");
        }

    }
}
