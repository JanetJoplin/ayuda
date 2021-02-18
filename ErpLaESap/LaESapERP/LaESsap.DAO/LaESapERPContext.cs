using LaESap.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESsap.DAO
{
    public class LaESapERPContext : DbContext
    {
        public LaESapERPContext() : base("name=LaESapERPConnection")
        {

            this.Configuration.LazyLoadingEnabled = false;
        }

        // ZZCONTEXT
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<TipoEquipo> TipoEquipos { get; set; }
        public DbSet<Procedencia> Procedencias { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Examen> Examenes { get; set; }
        public DbSet<TipoMuestra> TipoMuestras { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            //modelBuilder.Entity<Equipo>()
            //    .Property(p => p.DiasDeVida)
            //    .HasComputedColumnSql(" DATEDIFF(day,  [FechaAdquisicion], GETDATE()  )");
        }

    }

}

