using SistemaBancario.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaBancario.Services
{
    public interface ITarjetaService
    {
        Task<IEnumerable<Tarjeta>> GetAll();

        Task<Tarjeta> GetById(int id);

        Task<Tarjeta> GetByNumtarjeta(string numeroTarjeta);

        Task<bool> Exists(string tarjeta);

        Task<bool> Update(Tarjeta tarjeta);
    }
}
