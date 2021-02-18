namespace LaESsap.DAO.Migrations
{
    using LaESap.Modelo;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<LaESsap.DAO.LaESapERPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

        }

        protected override void Seed(LaESsap.DAO.LaESapERPContext context)
        {


            //context.Cargos.AddOrUpdate(x => x.Id, new Cargo()
            //{
            //    Id = 1,
            //    Estatus = 1,
            //    Nombre = "Jefe MB Micobacterias",
            //    FechaAlta = DateTime.ParseExact("2020-10-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
            //     FechaCambio = DateTime.ParseExact("2020-10-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)
            //});



            // https://weblog.west-wind.com/posts/2016/jan/13/resetting-entity-framework-migrations-to-a-clean-slate

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

        }
    }
}
