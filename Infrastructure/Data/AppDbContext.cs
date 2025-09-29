using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        //Referencia a la entidad
        public DbSet<Company> Companies { get; set; }

        //Constructor con las opciones de configuración de la base de datos
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        //Configuración del modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar valores por defecto para fechas
            modelBuilder.Entity<Company>()
                .Property(e => e.FechaCreacion)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Company>()
                .Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("GETDATE()");
        }

        //Se sobreescriben las fechas de creación y actualización
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<Company>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.FechaCreacion = DateTime.Now;
                    entry.Entity.FechaActualizacion = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.FechaActualizacion = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        //Método para guardar cambios de forma asíncrona
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<Company>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.FechaCreacion = DateTime.Now;
                    entry.Entity.FechaActualizacion = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.FechaActualizacion = DateTime.Now;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
