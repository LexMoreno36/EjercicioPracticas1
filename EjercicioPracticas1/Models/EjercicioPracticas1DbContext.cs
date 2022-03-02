using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EjercicioPracticas1.Models
{
    public partial class EjercicioPracticas1DbContext : DbContext
    {
        public EjercicioPracticas1DbContext()
            : base("name=EjercicioPracticas1DbContext")
        {
        }

        public virtual DbSet<DocVentas> DocVentas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocVentas>()
                .Property(e => e.EstadoPedido)
                .IsUnicode(false);

            modelBuilder.Entity<DocVentas>()
                .Property(e => e.DescPedido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Activo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.DocVentas)
                .WithRequired(e => e.Usuarios)
                .WillCascadeOnDelete(false);
        }
    }
}
