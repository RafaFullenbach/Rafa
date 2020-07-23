using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroClientes.Models;
using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CadastroClientes.Repository.Context
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
             if (!optionsBuilder.IsConfigured)
               {
                    var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                    optionsBuilder.UseOracle(config.GetConnectionString("CadastroClientesConnection"));
               }

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }
    }
}
