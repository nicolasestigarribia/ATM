using SistemaBancario.Data;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net;

namespace SistemaBancario.Services
{
    public class TarjetaServicio : ITarjetaService
    {
        private readonly HttpClient httpClient;

        private string Endpoint;

        public TarjetaServicio(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.Endpoint = "api/Tarjetas";
        }

        public async Task<bool> Exists(string tarjeta)
        {
            var aux = await httpClient.GetAsync($"{Endpoint}/exists/{tarjeta}");
            return aux.StatusCode == HttpStatusCode.OK;
        }

        public async Task<IEnumerable<Tarjeta>> GetAll()
        {

            return await httpClient.GetFromJsonAsync<List<Tarjeta>>($"{Endpoint}");
        }

        public async Task<Tarjeta> GetById(int id)
        {
            var aux = await httpClient.GetFromJsonAsync<Tarjeta>($"{Endpoint}/{id}");
            return aux; 
        }

        public async Task<Tarjeta> GetByNumtarjeta(string numeroTarjeta)
        {
            return await httpClient.GetFromJsonAsync<Tarjeta>($"{Endpoint}/numero/{numeroTarjeta}");
        }

        public async Task<bool> Update(Tarjeta tarjeta)
        {
            var rta= await httpClient.PutAsJsonAsync($"{Endpoint}/{tarjeta.IdTarjeta}", tarjeta);
            return rta.StatusCode == HttpStatusCode.NoContent;
        }
    }
}
