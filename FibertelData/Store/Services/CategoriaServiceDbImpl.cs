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
    public class CategoriaServiceDbImpl : ICategoriaService
    {
        private readonly FibertelDbContext _db;

        public CategoriaServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR CATEGORIA
        public Categoria Create(Categoria entity)
        {
            CategoriaTable categoriaTable = entity.ToTable();
            _db.categorias.Add(categoriaTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idCategoria = categoriaTable.idCategoria;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear la Categoria");
            }
        }

        public Categoria Delete(int id)
        {
            throw new NotImplementedException();
        }

        //LISTAR CATEGORIAS
        public List<Categoria> GetAll()
        {
            List<Categoria> list = _db.categorias
                .Select<CategoriaTable, Categoria>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //SELECCIONAR POR ID CATEGORIA
        public Categoria? GetById(int id)
        {
            CategoriaTable? categoria = _db.categorias
                .FirstOrDefault(r => r.idCategoria == id);
            if (categoria == null) return null;
            return categoria.ToModel();
        }

        //ACTUALIZAR CATEGORIA 
        public void Update(int id, Categoria entity) 
        {
            CategoriaTable? categoria = _db.categorias.FirstOrDefault(r => r.idCategoria == id);
            if (categoria == null) throw new MessageExeption("No se encontró la Categoria");
            categoria.categoriaNombre = entity.categoriaNombre;
            categoria.imagen = entity.imagen;
            categoria.estado = entity.estado;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo actualizar la Categoria");
        }

        void ICrud<Categoria>.Delete(int id)
        {
            throw new NotImplementedException();
        }

   
    }
}
