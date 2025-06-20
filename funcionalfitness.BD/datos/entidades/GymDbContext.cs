using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace funcionalfitness.BD.datos.entidades
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) { }


        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Clase> Clases { get; set; } = default!;
        public DbSet<ClienteClase> ClientesClases { get; set; } = default!;
        public DbSet<Notificacion> Notificaciones { get; set; } = default!;
        public DbSet<Categoria> Categorias { get; set; } = default!;

        public DbSet<ZonaCorporal> ZonasCorporales { get; set; } = default!;
        public DbSet<TipoEntrenamiento> TiposEntrenamiento { get; set; } = default!;
        

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Aquí puedes agregar configuraciones adicionales si es necesario
        }
    }
}
