using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using SistemaBancario.Services;
using System.Threading.Tasks;

namespace SistemaBancario.Pages.Login
{
	public partial class Login
	{
		string numerotrjeta = string.Empty;
		string numeroSinGuion = string.Empty;

		string message = string.Empty;

		[Inject]
		private ITarjetaService tarjetaService { get; set; }

		[Inject]
		private IOperacionService operacionService { get; set; }

		[Inject]
		private ILocalStorageService localStorageService { get; set; }

		[Inject]
		public NavigationManager Navegador { get; set; }

		private void obtener(int value)
		{
			//voy guardando la tarjeta sin guines para comparar el tamaño
			numeroSinGuion = $"{numeroSinGuion}{value}";

			//variable para mostrar en el textbox
			if (numeroSinGuion.Length <= 16)
			{
				numerotrjeta = $"{numerotrjeta}{value}";
			}
			else
			{
				message = "Tarjeta no valida";
			}

			if (numeroSinGuion.Length == 4 || numeroSinGuion.Length == 8 || numeroSinGuion.Length == 12)
			{
				numerotrjeta += '-';
			}
		}
		private void cancelar()
		{
			numerotrjeta = string.Empty;
			numeroSinGuion = string.Empty;
			message = "";
		}

		private async Task ValidarTarjetaAsync()
		{
			var numeroTarjeta = numerotrjeta.Replace("-", "");
			if (numeroTarjeta != string.Empty && numeroTarjeta.Length == 16)
			{
				var aux = await tarjetaService.Exists(numeroTarjeta);
				if (aux)
				{
					var tarjeta = await tarjetaService.GetByNumtarjeta(numeroTarjeta);
					if (tarjeta != null)
					{
						if (tarjeta.Bloqueada == false)
						{
							Navegador.NavigateTo($"/pin/{tarjeta.IdTarjeta}", forceLoad: true);

						}else
                        {
							message = "Su tarjeta se encuentra bloqueada";
                        }
					}else
                    {
						message = "Tarjeta no registrada";
                    }
				}else
                {
					message = "Numero de tarjeta invalido";
                }
			}else
            {
				message = "Ingrese un numero valido";
            }
		}
	}
}
