using Microsoft.EntityFrameworkCore;
using Departamentos.Domain.Entities;

namespace Departamentos.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(d => d.Id);
                entity.Property(d => d.Nome).IsRequired().HasMaxLength(100);
                entity.Property(d => d.Sigla).IsRequired().HasMaxLength(10);
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(f => f.Id);
                entity.Property(f => f.Nome).IsRequired().HasMaxLength(100);
                entity.Property(f => f.Foto).HasMaxLength(255);
                entity.Property(f => f.RG).IsRequired().HasMaxLength(20);
                entity.HasOne(f => f.Departamento)
                      .WithMany(d => d.Funcionarios)
                      .HasForeignKey(f => f.DepartamentoId);
            });
        }
    }
}