using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GABI\\SQLEXPRESS;database=EntidadFinanciera;trusted_connection=true;Encrypt=False");
        }
    }
}
