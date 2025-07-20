using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entidades;

namespace minimal_api.Infraestrutura.Data
{

    // DbContext para a aplicação, gerencia a interação com o banco de dados
    public class MinimalApiDbContext : DbContext
    {
        private readonly IConfiguration _configuracaoAppSettings;
        // Construtor que injeta a configuração da aplicação
        public MinimalApiDbContext(IConfiguration configuracaoAppSettings)
        {
            _configuracaoAppSettings = configuracaoAppSettings;
        }
        public DbSet<Administrador> Administradores { get; set; } = default!;
        public DbSet<Veiculo> Veiculos { get; set; } = default!;
        // Configura o modelo de dados e popula dados iniciais (seed)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Adiciona um administrador inicial ao banco de dados.
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
        // Configura as opções do DbContext, como a string de conexão.
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