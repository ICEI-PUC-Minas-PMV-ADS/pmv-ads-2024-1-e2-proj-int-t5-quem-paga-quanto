using Microsoft.EntityFrameworkCore;

namespace QuemPagaQuanto.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Grupo> Grupos { get; set; }

        public DbSet<Morador> Moradores { get; set; }
    }

}
