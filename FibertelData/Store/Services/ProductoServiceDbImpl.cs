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
    public class ProductoServiceDbImpl : IProductoService
    {
        private readonly FibertelDbContext _db;

        public ProductoServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR PRODUCTO
        public Producto Create(Producto entity)
        {
            ProductoTable productoTable = entity.ToTable();
            _db.productos.Add(productoTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idProducto = productoTable.idProducto;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear el Producto");
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        //LISTAR PRODUCTOS
        public List<Producto> GetAll()
        {
            List<Producto> list = _db.productos
                .Select<ProductoTable, Producto>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }


        //SELECCIONAR POR ID PRODUCTO
        public Producto? GetById(int id)
        {
            ProductoTable? producto = _db.productos
                .FirstOrDefault(r => r.idProducto == id);
            if (producto == null) return null;
            return producto.ToModel();
        }

        //ACTUALIZAR PRODUCTO 
        public void Update(int id, Producto entity)
        {
            ProductoTable? producto = _db.productos.FirstOrDefault(r => r.idProducto == id);
            if (producto == null) throw new MessageExeption("No se encontró el Producto");
            producto.productoNombre = entity.productoNombre;
            producto.precio = entity.precio;
            producto.precioOferta = entity.precioOferta;
            producto.cantidad = entity.cantidad;
            producto.detalle = entity.detalle;
            producto.estado = entity.estado;
            producto.imagen01 = entity.imagen01;
            producto.imagen02 = entity.imagen02;
            producto.imagen03 = entity.imagen03;
            producto.imagen04 = entity.imagen04;
            producto.idCategoria = entity.idCategoria;
            producto.idMarca = entity.idMarca;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo actualizar el Producto");
        }

        public List<Producto> search(string Nombre)
        {
            List<Producto> list = _db.productos
                .Where(r => r.productoNombre.ToLower().Contains(Nombre.ToLower()))
                .Select(rt => rt.ToModel())
                .ToList();
            return list;
        }


    }
}
