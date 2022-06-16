using System;
using System.ComponentModel.DataAnnotations;

namespace BancoApi.Models
{
    public class Operacion
    {

        [Key]
        public int IdOperacion { get; set; }
        public int IdTarjeta{ get; set; }
        public int CodigoOperacion{ get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
        public double Monto { get; set; }
    }
}
