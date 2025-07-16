using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entidades;

namespace minimal_api.Infraestrutura.Data
{
    public class MinimalApiDbContext : DbContext
    {
        private readonly IConfiguration _configuracaoAppSettings;

        public MinimalApiDbContext(IConfiguration configuracaoAppSettings)
        {
            _configuracaoAppSettings = configuracaoAppSettings;
        }
        public DbSet<Administrador> Administradores { get; set; } = default!;
        public DbSet<Veiculo> Veiculos { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>().HasData(
                new Administrador
                {
                    Id = 1,
                    Email = "administrador@teste.com",
                    Senha = "123456",
                    Perfil = "Adm"
                }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var stringConnection = _configuracaoAppSettings.GetConnectionString("DefaultConnection")?.ToString();
                if (!string.IsNullOrEmpty(stringConnection))
                {
                    optionsBuilder.UseSqlServer(
                        stringConnection);
                }
            }

        }
    }
}