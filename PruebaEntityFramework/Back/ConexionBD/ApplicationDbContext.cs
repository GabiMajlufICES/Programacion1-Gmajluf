using Microsoft.EntityFrameworkCore;

namespace Back.ConexionBD
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GABRIEL\\SQLEXPRESS;database=PruebaEF;trusted_connection=true;Encrypt=False");
        }

    }
}
