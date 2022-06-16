using System;

namespace SistemaBancario.Data
{
    public class Operacion
    {
        public int IdOperacion { get; set; }
        public int IdTarjeta { get; set; }
        public int CodigoOperacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
        public double Monto { get; set; }

        public Operacion()
        {
        }

        public Operacion(int idTarjeta, int codigoOperacion, string descripcion, DateTime fechaHora, double monto)
        {
            IdTarjeta = idTarjeta;
            CodigoOperacion = codigoOperacion;
            Descripcion = descripcion;
            FechaHora = fechaHora;
            Monto = monto;
        }

        public Operacion(int idTarjeta, int codigoOperacion, string descripcion, DateTime fechaHora)
        {
            IdTarjeta = idTarjeta;
            CodigoOperacion = codigoOperacion;
            Descripcion = descripcion;
            FechaHora = fechaHora;
        }


    }
}
