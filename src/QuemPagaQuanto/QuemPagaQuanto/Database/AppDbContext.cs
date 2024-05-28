using Microsoft.EntityFrameworkCore;
using QuemPagaQuanto.Models;

namespace QuemPagaQuanto.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Grupo> Grupos { get; set; }

        public DbSet<Morador> Moradores { get; set; }

        public DbSet<Despesa> Despesas { get; set; }

        public DbSet<Renda> Rendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = -1,
                    Email = "admin@admin.com",
                    Nome = "Administrador",
                    Senha = "$2a$11$rPjjjKA4B.FyE00Cjv8vw.tfB2ZMQTFgEZcasPzytrU38oIBunr4e",
                    Perfil = Perfil.Administrador
                }
            );
        }
    }
}
