using SistemaDenunciasMinimalApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace SistemaDenunciasMinimalApi.Data
{
    public class DenunciaContext : DbContext
    {
        public DenunciaContext(DbContextOptions<DenunciaContext> options) : base(options)
        {
        }

        public DbSet<Denuncia> Denuncias { get; set; } = null!;

        public DbSet<TipoDenuncia> TiposDenuncia { get; set; } = null!;

        public DbSet<EstadoDenuncia> estadosDenuncia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Denuncia>()
                .Property(d => d.Estado)
                .HasDefaultValue(1);

            modelBuilder.Entity<TipoDenuncia>()
                .HasIndex(t => t.Nombre)
                .IsUnique();

            // Seed data para Estados de Denuncia
            modelBuilder.Entity<EstadoDenuncia>().HasData(
                new EstadoDenuncia { Id = 1, Nombre = "Pendiente" },
                new EstadoDenuncia { Id = 2, Nombre = "En Proceso" },
                new EstadoDenuncia { Id = 3, Nombre = "Resuelta" },
                new EstadoDenuncia { Id = 4, Nombre = "Rechazada" }
            );

            // Seed data para Tipos de Denuncia
            modelBuilder.Entity<TipoDenuncia>().HasData(
                new TipoDenuncia { Id = 1, Nombre = "Robo" },
                new TipoDenuncia { Id = 2, Nombre = "Acoso" },
                new TipoDenuncia { Id = 3, Nombre = "Daño" },
                new TipoDenuncia { Id = 4, Nombre = "Otro" }
            );
        }
    }
}