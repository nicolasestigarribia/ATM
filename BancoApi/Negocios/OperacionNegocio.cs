using BancoApi.Data;
using BancoApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BancoApi.Negocios
{
    public class OperacionNegocio
    {
        public readonly AplicationDbContext _context;

        public OperacionNegocio(AplicationDbContext context)
        {
            _context = context;
        }

        public OperacionNegocio()
        {
        }

        public IEnumerable<Operacion> GetAll()
        {
            return _context.operaciones.ToList();
        }

        public Operacion GetById(int idoperacion)
        {
            return _context.operaciones.Where(t => t.IdOperacion == idoperacion).SingleOrDefault();
        }

        public bool Exists(int operacion)
        {
            return _context.operaciones.Any(t => t.IdOperacion == operacion);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool Insert(Operacion operacionNew)
        {
            _context.operaciones.Add(operacionNew);
            return Save();
        }

        public bool Update(Operacion operacion)
        {
            Operacion operacionToUpdate = GetById(operacion.IdOperacion);
            _context.Entry(operacionToUpdate).CurrentValues.SetValues(operacion);
            return Save();
        }

        public List<Operacion> GetListaByIdTarjeta(int idTarjeta)
        {
           return  _context.operaciones.Where(o => o.IdTarjeta == idTarjeta).ToList();
        }

    }
}
