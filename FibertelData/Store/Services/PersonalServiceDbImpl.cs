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
    public class PersonalServiceDbImpl : IPersonalService
    {
        private readonly FibertelDbContext _db;

        public PersonalServiceDbImpl(FibertelDbContext db)
        {
            _db = db;
        }

        //CREAR PERSONAL
        public Personal Create(Personal entity)
        {
            PersonalTable personalTable = entity.ToTable();
            _db.personals.Add(personalTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.idPersonal = personalTable.idPersonal;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se puede crear el Personal");
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        //LISTAR PERSONALES
        public List<Personal> GetAll()
        {
            List<Personal> list = _db.personals
                .Select<PersonalTable, Personal>(
                    rt => rt.ToModel()
                ).ToList();
            return list;
        }

        //VER PERSONAL POR ID 
        public Personal? GetById(int id)
        {
            PersonalTable? personal = _db.personals
                .FirstOrDefault(r => r.idPersonal == id);
            if (personal == null) return null;
            return personal.ToModel();

        }


        //ACTUALIZAR PERSONAL 
        public void Update(int id, Personal entity)
        {
            PersonalTable? personal = _db.personals.FirstOrDefault(r => r.idPersonal == id);
            if (personal == null) throw new MessageExeption("No se encontró el Personal");
            personal.nombres = entity.nombres;
            personal.apellidos = entity.apellidos;
            personal.rol = entity.rol;
            personal.contacto = entity.contacto;
            personal.numeroDocumento = entity.numeroDocumento;
            personal.finOperacion = entity.finOperacion;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo actualizar el Personal");
        }

    }
}
