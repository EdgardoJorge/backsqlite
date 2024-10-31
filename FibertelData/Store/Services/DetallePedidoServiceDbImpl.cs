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
    public class DetallePedidoServiceDbImpl : IDetallePedidoService
    {
        private readonly FibertelDbContext _db;

        public DetallePedidoServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR DETALLEPEDIDO
        public DetallePedido Create(DetallePedido entity)
        {
            DetallePedidoTable detallePedidoTable = entity.ToTable();
            _db.detallePedidos.Add(detallePedidoTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idDetallePedido = detallePedidoTable.idDetallePedido;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear el Detalle del Pedido");
            }
        }

        public DetallePedido Delete(int id)
        {
            throw new NotImplementedException();
        }

        //LISTAR DETALLEPEDIDO
        public List<DetallePedido> GetAll()
        {
            List<DetallePedido> list = _db.detallePedidos
                .Select<DetallePedidoTable, DetallePedido>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //SELECCIONAR POR ID DETALLEPEDIDO
        public DetallePedido? GetById(int id)
        {
            DetallePedidoTable? detallePedido = _db.detallePedidos
                .FirstOrDefault(r => r.idDetallePedido == id);
            if (detallePedido == null) return null;
            return detallePedido.ToModel();
        }

        public DetallePedido Update(int id, DetallePedido entity)
        {
            throw new NotImplementedException();
        }

        void ICrud<DetallePedido>.Delete(int id)
        {
            throw new NotImplementedException();
        }


        //LISTAR DETALLEPEDIDO
        public List<DetallePedido> GetByPedidoId(int idPedido)
        {
            List<DetallePedido> list = _db.detallePedidos
                .Where(dp => dp.idPedido == idPedido)
                .Select<DetallePedidoTable, DetallePedido>(
                    rt => rt.ToModel()
                )
                .ToList();

             return list;
        }

        void ICrud<DetallePedido>.Update(int id, DetallePedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
