using FibertelData.Sources.BaseDeDatos;
using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelData.Store.Extentions;
using FibertelDomain.Errors;
using FibertelDomain.Store.Models;
using FibertelDomain.Store.Services;
using FibertelDomain.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Services
{
    public class PedidoServiceDbImpl : IPedidoService
    {
        private readonly FibertelDbContext _db;

        public PedidoServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR PEDIDO
        public Pedido Create(Pedido entity)
        {
            PedidoTable pedidoTable = entity.ToTable();
            _db.pedidos.Add(pedidoTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idPedido = pedidoTable.idPedido;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear el Pedido");
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        //LISTAR PEDIDOS
        public List<Pedido> GetAll()
        {
            List<Pedido> list = _db.pedidos
                .Select<PedidoTable, Pedido>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //SELECCIONAR POR ID PEDIDO
        public Pedido? GetById(int id)
        {
            PedidoTable? pedido = _db.pedidos
                .FirstOrDefault(r => r.idPedido == id);
            if (pedido == null) return null;
            return pedido.ToModel();
        }

        //ACTUALIZAR PEDIDO 
        public void Update(int id, Pedido entity)
        {
            PedidoTable? pedido = _db.pedidos.FirstOrDefault(r => r.idPedido == id);
            if (pedido == null) throw new MessageExeption("No se encontró el Pedido");
            pedido.fechaCancelado = entity.fechaCancelado;
            pedido.estado = entity.estado;
            pedido.idPersonal = entity.idPersonal;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo actualizar el Pedido");
        }



        //MOSTRAR UN PEDIDO POR SU IDENVIO

        public Pedido? GetPedidoByIdEnvio(int idEnvio)
        {
            Pedido? pedido = _db.pedidos
                .Where(p => p.idEnvio == idEnvio)
                .Select(rt => rt.ToModel())
                .FirstOrDefault();

            return pedido;
        }

        //MOSTRAR UN PEDIDO POR SU IDENVIO

        public Pedido? GetPedidoByIdRecojo(int idRecojo)
        {
            Pedido? pedido = _db.pedidos
                .Where(p => p.idRecojo == idRecojo)
                .Select(rt => rt.ToModel())
                .FirstOrDefault();

            return pedido;
        }

        //LISTAR PEDIDOS CON ESTADO PENDIENTE

        public List<Pedido> GetPedidosPendientes()
        {
            return _db.pedidos
                .Where(p => p.estado == "Pendiente")
                .Select(p => new Pedido
                {
                })
                .ToList();
        }

        //LISTAR PEDIDOS CON ESTADO ENTREGADO

        public List<Pedido> GetPedidosEntregados()
        {
            return _db.pedidos
                .Where(p => p.estado == "Entregado")
                .Select(p => new Pedido
                {
                })
                .ToList();
        }

        //LISTAR PEDIDOS CON ESTADO ENTREGADO

        public List<Pedido> GetPedidosCancelados()
        {
            return _db.pedidos
                .Where(p => p.estado == "Cancelado")
                .Select(p => new Pedido
                {
                })
                .ToList();
        }

        //LISTAR PEDIDOS CON ESTADO ENTREGADO

        public List<Pedido> GetPedidosEnviados()
        {
            return _db.pedidos
                .Where(p => p.estado == "Enviado")
                .Select(p => new Pedido
                {
                })
                .ToList();
        }

        //LISTAR LA CANTIDAD DE PEDIDOS
        public int GetTotalPedidos()
        {
            return _db.pedidos.Count();
        }

        //CONTEO TOTAL DE LA CANTIDAD DE INGRESOS
        public decimal GetSumaTotalPedidos()
        {
            return _db.pedidos.Sum(p => p.total);
        }


        public List<Pedido> GetPedidosByFilters(int? idPedido, string numeroDocumento)
        {
            return _db.pedidos
                .Where(p => (!idPedido.HasValue || p.idPedido == idPedido.Value) &&
                           (string.IsNullOrEmpty(numeroDocumento) || p.Cliente.numeroDocumento == numeroDocumento))
                .Select(p => p.ToModel())
                .ToList();
        }

    }
}
