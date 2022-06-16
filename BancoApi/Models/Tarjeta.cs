using System;
using System.ComponentModel.DataAnnotations;

namespace BancoApi.Models
{
    public class Tarjeta
    {
        [Key]
        public int IdTarjeta { get; set; }
        public string NumeroTarjeta { get; set; }
        public bool Bloqueada { get; set; }
        public double Balance { get; set; }
        public int Pin { get; set; }
        public DateTime FechaVencimiento {get;set;}
    }
}
