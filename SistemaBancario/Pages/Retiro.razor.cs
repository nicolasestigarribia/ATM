using Microsoft.AspNetCore.Components;
using SistemaBancario.Data;
using SistemaBancario.Services;
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Pages
{
    public partial class Retiro
    {
        string numerotrjeta = string.Empty;
        string monto = string.Empty;
        string message = string.Empty;
		string message2 = string.Empty;


		[Inject]
		private ITarjetaService tarjetaService { get; set; }

		[Inject]
		private IOperacionService operacionService { get; set; }

		[Inject]
		public NavigationManager Navegador { get; set; }


		private void obtener(int value)
		{
			//voy guardando la tarjeta sin guines para comparar el tamaño
			monto = $"{monto}{value}";

			//variable para mostrar ene l textbox
			numerotrjeta = $"{numerotrjeta}{value}";
		}

		private async void Aceptar()
        {
			//me traigo el ID de la tarjeta que esta en el local storage

			var tarjeta = await tarjetaService.GetById(1);
			var montoDouble = Convert.ToDouble(monto);
			if (tarjeta.Balance > montoDouble)
            {
				//Creo la operacion
				await operacionService.Insert(new Operacion(tarjeta.IdTarjeta, 1, "Retiro", DateTime.Now, Convert.ToDouble(monto)));
				// creo el registro en la bdd
				tarjeta.Balance = tarjeta.Balance - Convert.ToDouble(monto);
				//Hago update del monto de la tarjeta
				await tarjetaService.Update(tarjeta);

				message = string.Empty;
				numerotrjeta = string.Empty; ;
				
				message2 = "Retiro realizado con exito";
				Navegador.NavigateTo($"/Comprobante/{tarjeta.IdTarjeta}/{monto}");
            }else
            {
				message2 = string.Empty;
				message = "Monto excedido";
            }
        }

		private void cancelar()
		{
			numerotrjeta = string.Empty;
			message = "";
		}

		private void Salir()
		{
			Navegador.NavigateTo("/");
		}
	}
}
