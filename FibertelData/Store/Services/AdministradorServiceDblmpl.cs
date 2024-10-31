using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelData.Sources.BaseDeDatos;
using FibertelDomain.Store.Services;
using FibertelDomain.Store.Models;
using FibertelDomain.Errors;
using FibertelDomain.Utils;
//using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibertelData.Store.Extentions;

namespace FibertelData.Store.Services
{
    public class AdministradorServiceDblmpl : IAdministradorService
    {
        private readonly FibertelDbContext _db;

        public AdministradorServiceDblmpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR ADMINISTRADOR
        public Administrador Create(Administrador entity)
        {
            AdministradorTable administradorTable = entity.ToTable();
            _db.administradors.Add(administradorTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idAdministrador = administradorTable.idAdministrador;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se pudo crear el administrador");
            }
        }

        public Administrador Delete(int id)
        {
            throw new NotImplementedException();
        }

        //LISTAR ADMIS
        public List<Administrador> GetAll()
        {
            List<Administrador> list = _db.administradors
                .Select<AdministradorTable, Administrador>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }
        //SELECCIONAR ADMIN POR ID
        public Administrador? GetById(int id)
        {
            AdministradorTable? administrador = _db.administradors
                .FirstOrDefault(r => r.idAdministrador == id);
            if (administrador == null) return null;
            return administrador.ToModel();
        }

        //ACTUALIZAR ADMIN
        public void Update(int id, Administrador entity)
        {
            AdministradorTable? administrador = _db.administradors
                .FirstOrDefault(r => r.idAdministrador == id);
            if (administrador == null) throw new MessageExeption("No se encontro el Administrador");
            administrador.nombres = entity.nombres;
            administrador.telefonoMovil = entity.telefonoMovil;
            administrador.email = entity.email;
            administrador.estado = entity.estado;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo actualizar el administrador");
        }

        void ICrud<Administrador>.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
