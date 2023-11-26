using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Ruleta.Server.Models
{
    public class RuletaContext : DbContext
    {
        public DbSet<jugadores> jugadores => Set<jugadores>();
        public DbSet<opciones> opciones => Set<opciones>();
        public DbSet<nombres> nombres => Set<nombres>();

        public RuletaContext(DbContextOptions<RuletaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}