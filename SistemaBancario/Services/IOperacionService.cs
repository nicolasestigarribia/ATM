using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaBancario.Data;

namespace SistemaBancario.Services
{
    public interface IOperacionService
    {
        Task<IEnumerable<Operacion>> GetAll();

        Task<Operacion> GetById(int id);

        Task<bool> Exists(int operacion);

        Task<bool> Update(Operacion operacion);

        Task<bool> Insert(Operacion operacion);

         Task<IEnumerable<Operacion>> GetListaByIdTarjeta(int idTarjeta);


    }
}
