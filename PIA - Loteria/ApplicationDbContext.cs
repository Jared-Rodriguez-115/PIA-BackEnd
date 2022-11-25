using Microsoft.EntityFrameworkCore;
using PIA___Loteria.Entidades;

namespace PIA___Loteria
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Rifa>  Rifas { get; set; }
    }
}
