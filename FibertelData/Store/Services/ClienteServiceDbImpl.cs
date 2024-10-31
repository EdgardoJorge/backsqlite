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
    public class ClienteServiceDbImpl : IClienteService
    {
        private readonly FibertelDbContext _db;

        public ClienteServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR CATEGORIA
        public Cliente Create(Cliente entity)
        {
            ClienteTable clienteTable = entity.ToTable();
            _db.clientes.Add(clienteTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idCliente = clienteTable.idCliente;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear la Categoria");
            }
        }

        public Cliente Delete(int id)
        {
            throw new NotImplementedException();
        }

        //LISTAR CLIENTE
        public List<Cliente> GetAll()
        {
            List<Cliente> list = _db.clientes
                .Select<ClienteTable, Cliente>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //SELECCIONAR POR ID CLIENTE
        public Cliente? GetById(int id)
        {
            ClienteTable? cliente = _db.clientes
                .FirstOrDefault(r => r.idCliente == id);
            if (cliente == null) return null;
            return cliente.ToModel();
        }

        public Cliente Update(int id, Cliente entity)
        {
            throw new NotImplementedException();
        }

        void ICrud<Cliente>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void ICrud<Cliente>.Update(int id, Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
