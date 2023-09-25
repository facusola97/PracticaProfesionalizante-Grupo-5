using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Ingredientes> ingredientes { get; set; }
        public DbSet<Opcion> opciones { get; set; }
        public DbSet<OpcionPedido> opcionesPedidos { get; set; }
        public DbSet<IngredientesOpcion> ingredientesOpciones { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
        public DbSet<Reporte> reporte { get; set; } 
        public DbSet<ReportePedidos> reportePedidos { get; set; }   
        public DbSet<Usuario> usuarios { get; set; }    


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-LCHL84OT\\SQLEXPRESS;database=ProyectoBD;trusted_connection=true;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Agrega aquí la configuración del tipo de columna SQL para la propiedad 'Precio'
            // para las entidades 'Ingredientes' y 'Opcion'
            modelBuilder.Entity<Ingredientes>()
                .Property(e => e.Precio)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Opcion>()
                .Property(e => e.Precio)
                .HasColumnType("decimal(18, 2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}