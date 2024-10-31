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
    public class ComprobanteServiceDbImpl : IComprobanteService
    {
        private readonly FibertelDbContext _db;

        public ComprobanteServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR COPMPROBANTE
        public Comprobante Create(Comprobante entity)
        {
            ComprobanteTable comprobanteTable = entity.ToTable();
            _db.comprobantes.Add(comprobanteTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idComprobante = comprobanteTable.idComprobante;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear el Comprobante");
            }
        }

        public Comprobante Delete(int id)
        {
            throw new NotImplementedException();
        }

        //LISTAR COMPROBANTE
        public List<Comprobante> GetAll()
        {
            List<Comprobante> list = _db.comprobantes
                .Select<ComprobanteTable, Comprobante>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //SELECCIONAR POR ID COMPROBANTE
        public Comprobante? GetById(int id)
        {
            ComprobanteTable? comprobante = _db.comprobantes
                .FirstOrDefault(r => r.idComprobante == id);
            if (comprobante == null) return null;
            return comprobante.ToModel();
        }

        public Comprobante Update(int id, Comprobante entity)
        {
            throw new NotImplementedException();
        }

        void ICrud<Comprobante>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void ICrud<Comprobante>.Update(int id, Comprobante entity)
        {
            throw new NotImplementedException();
        }
    }
}
