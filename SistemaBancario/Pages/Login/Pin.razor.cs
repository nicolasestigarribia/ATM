using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using SistemaBancario.Auth;
using SistemaBancario.Services;
using System;
using System.Threading.Tasks;

namespace SistemaBancario.Pages.Login
{
	public partial class Pin
	{

		string numerotrjeta = string.Empty;
		string message = string.Empty;
		int contador = 0;

		[Inject]
		private ITarjetaService tarjetaService { get; set; }

		[Inject]
		private ISessionStorageService localStorageService { get; set; }

		[Inject]
		public NavigationManager Navegador { get; set; }

		[Inject]
		public AuthenticationProvider authenticationProvider { get; set; }

		[Parameter]
		public int Id { get; set; }

		private void obtener(int value)
		{
			if (numerotrjeta.Length < 4)
			{
				numerotrjeta = $"{numerotrjeta}{value}";
			}
		}
		private async Task Ingresar()
        {
			var tarjeta = await tarjetaService.GetById(Id);
			var pin = Convert.ToInt32(numerotrjeta);
			if (numerotrjeta.Length == 4 && contador <=4)
            {
				if (tarjeta != null && tarjeta.Pin == pin)
				{
					await localStorageService.SetItemAsync("KEY", tarjeta.IdTarjeta);
					authenticationProvider.NotificarLogin(tarjeta.IdTarjeta);
					Navegador.NavigateTo("/Index");
				}else
                {
					contador = contador + 1;
					message = $"PIN incorrecto, le quedan {4-contador} intentos ";
                }
			}
            else
            {
				contador = contador + 1;
				message = $"PIN incorrecto, le quedan {4 - contador} intentos ";
            }
			if(contador >= 4)
            {
				tarjeta.Bloqueada = true;
				await tarjetaService.Update(tarjeta);
				Navegador.NavigateTo($"/Error/{"Tarjeta bloqueada"}", forceLoad:true);
				authenticationProvider.NotificarLogOut();
            }
        }
		private void cancelar()
		{
			numerotrjeta = string.Empty;
		}

		private void Salir()
        {
			Navegador.NavigateTo("/Salir");
        }

	}
}
