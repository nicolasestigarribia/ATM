using BancoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoApi.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Tarjeta> tarjetas { get; set; }
        public DbSet<Operacion> operaciones { get; set; }

        
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
    }
}
