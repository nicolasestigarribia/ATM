using BancoApi.Data;
using BancoApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BancoApi.Negocios
{
    public class TarjetaNegocio
    {
        public readonly AplicationDbContext _context;

        public TarjetaNegocio(AplicationDbContext context)
        {
            _context = context;
        }

        public TarjetaNegocio()
        {
        }

        public IEnumerable<Tarjeta> GetAll()
        {
            return _context.tarjetas.ToList();
        }

        public Tarjeta GetById(int idTarjeta)
        {
            return _context.tarjetas.Where(t => t.IdTarjeta == idTarjeta).SingleOrDefault();
        }

        public bool Exists(string tarjeta)
        {
            return _context.tarjetas.Any(t => t.NumeroTarjeta.ToLower().Trim() == tarjeta.ToLower().Trim());
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool Update(Tarjeta tarjeta)
        {
            Tarjeta tarjetaToUpdate = GetById(tarjeta.IdTarjeta);
            _context.Entry(tarjetaToUpdate).CurrentValues.SetValues(tarjeta);
            return Save();
        }

        public Tarjeta GetByNumTarjeta(string tarjeta)
        {
            return _context.tarjetas.SingleOrDefault(t => t.NumeroTarjeta.ToLower().Trim().Contains(tarjeta.ToLower().Trim()));
        }


    }
}
