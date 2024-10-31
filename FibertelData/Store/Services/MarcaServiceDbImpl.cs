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
    public class MarcaServiceDbImpl : IMarcaService
    {
        private readonly FibertelDbContext _db;

        public MarcaServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR MARCA
        public Marca Create(Marca entity)
        {
            MarcaTable marcaTable = entity.ToTable();
            _db.marcas.Add(marcaTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idMarca = marcaTable.idMarca;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear la Marca");
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        //LISTAR MARCAS
        public List<Marca> GetAll()
        {
            List<Marca> list = _db.marcas
                .Select<MarcaTable, Marca>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //SELECCIONAR POR ID MARCA
        public Marca? GetById(int id)
        {
            MarcaTable? marca = _db.marcas
                .FirstOrDefault(r => r.idMarca == id);
            if (marca == null) return null;
            return marca.ToModel();
        }

        //ACTUALIZAR MARCA 
        public void Update(int id, Marca entity)
        {
            MarcaTable? marca = _db.marcas.FirstOrDefault(r => r.idMarca == id);
            if (marca == null) throw new MessageExeption("No se encontró la Marca");
            marca.marcaNombre = entity.marcaNombre;
            marca.imagen = entity.imagen;
            marca.estado = entity.estado;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo actualizar la Marca");
        }
    }
}
