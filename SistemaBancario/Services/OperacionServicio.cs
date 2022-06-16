using SistemaBancario.Data;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SistemaBancario.Services
{
    public class OperacionServicio : IOperacionService
    {
        private readonly HttpClient httpClient;

        private string Endpoint;

        public OperacionServicio(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.Endpoint = "api/Operaciones";
        }

        public async Task<bool> Exists(int operacion)
        {
            return await httpClient.GetFromJsonAsync<bool>($"{Endpoint}/exists/{operacion}");
        }

        public async Task<IEnumerable<Operacion>> GetListaByIdTarjeta(int idTarjeta)
        {
            List<Operacion> lista = new List<Operacion>();

            lista= await httpClient.GetFromJsonAsync<List<Operacion>>($"{Endpoint}/tarjeta/{idTarjeta}");
            return lista;

        }

        public async Task<IEnumerable<Operacion>> GetAll()
        {
            List<Operacion> lista = new List<Operacion>();
            lista = await httpClient.GetFromJsonAsync<List<Operacion>>($"{Endpoint}");
            return lista;
        }

        public async Task<Operacion> GetById(int id)
        {
            var aux = await httpClient.GetFromJsonAsync<Operacion>($"{Endpoint}/{id}");
            return aux;
        }

        public async Task<bool> Insert(Operacion operacion)
        {
            var response = await httpClient.PostAsJsonAsync(Endpoint, operacion);
            return response.StatusCode == HttpStatusCode.Created;
        }

        public async Task<bool> Update(Operacion operacion)
        {
            var rta = await httpClient.PutAsJsonAsync($"{Endpoint}/{operacion.IdTarjeta}", operacion);
            return rta.StatusCode == HttpStatusCode.NoContent;
        }

     
    }
}
