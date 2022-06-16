using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Security.Claims;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http;
using Blazored.LocalStorage;
using Blazored.SessionStorage;

namespace SistemaBancario.Auth
{
    public class AuthenticationProvider : AuthenticationStateProvider
    {


        private readonly HttpClient HttpClient;
        public static string TOKEN_KEY = "TOKEN_KEY";
        public ISessionStorageService LocalStorage;
        public readonly IJSRuntime js;

        public AuthenticationProvider(ISessionStorageService localStorage, HttpClient httpClient)
        {
            this.HttpClient = httpClient;
            this.LocalStorage = localStorage;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await LocalStorage.GetItemAsync<int>("KEY");
            AuthenticationState result = new AuthenticationState(new ClaimsPrincipal());

            if (token != 0)
            {
                result = ConstruirAuthenticationState(token);
            }

            NotifyAuthenticationStateChanged(Task.FromResult(result));
            return await Task.FromResult(result);
        }

        private AuthenticationState ConstruirAuthenticationState(int idtarjeta)
        {
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsFromToken().ClaimsUsuario(idtarjeta)));
        }

        public async Task NotificarLogOut()
        {
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal())));
        }

        public async Task NotificarLogin(int idtarjeta)
        {
            var authState = ConstruirAuthenticationState(idtarjeta);
            NotifyAuthenticationStateChanged(Task.FromResult(authState));
        }

    }
}
