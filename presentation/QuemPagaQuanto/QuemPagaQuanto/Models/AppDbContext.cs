using Microsoft.EntityFrameworkCore;

namespace QuemPagaQuanto.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Grupo> Grupos { get; set; }

        public DbSet<Morador> Moradores { get; set; }

        public DbSet<Despesa> Despesas { get; set; }

        public DbSet<Renda> Rendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = -1,
                    Email = "admin@admin.com",
                    Nome = "Administrador",
                    Senha = BCrypt.Net.BCrypt.HashPassword("1234"),
                    Perfil = Perfil.Administrador
                }
            );
        }
    }
}
