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
    public class EnvioServiceDbImpl : IEnvioService
    {
        private readonly FibertelDbContext _db;

        public EnvioServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR ENVIO
        public Envio Create(Envio entity)
        {
            EnvioTable envioTable = entity.ToTable();
            _db.envios.Add(envioTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idEnvio = envioTable.idEnvio;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear el Envio");
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        //LISTAR ENVIOS
        public List<Envio> GetAll()
        {
            List<Envio> list = _db.envios
                .Select<EnvioTable, Envio>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //SELECCIONAR POR ID ENVIO
        public Envio? GetById(int id)
        {
            EnvioTable? envio = _db.envios
                .FirstOrDefault(r => r.idEnvio == id);
            if (envio == null) return null;
            return envio.ToModel();
        }

        //ACTUALIZAR ENVIO 
        public void Update(int id, Envio entity)
        {
            EnvioTable? envio = _db.envios.FirstOrDefault(r => r.idEnvio == id);
            if (envio == null) throw new MessageExeption("No se encontró el Envio");
            envio.fechaEnvio = entity.fechaEnvio;
            envio.fechaEntrega = entity.fechaEntrega;
            envio.responsableEntrega = entity.responsableEntrega;
            envio.idPersonal = entity.idPersonal;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo actualizar el Envio");
        }

    }
}
