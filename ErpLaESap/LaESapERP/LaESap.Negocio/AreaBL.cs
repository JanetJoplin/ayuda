using LaESap.Modelo;
using LaESsap.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Negocio
{
    public class AreaBL
    {




        public LaESapERPContext context;

        public AreaBL()
        {
            context = new LaESapERPContext();
        }
        public bool ActualizarArea(Area area)
        {
            context.Areas.AddOrUpdate(area);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public bool CrearArea(Area area)
        {

            try
            {
                context.Areas.Add(area);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                throw;
            }
        }

        public void EliminarAreaByID(int id)
        {
            Area oObjetoX = this.context.Areas.Find(id);
            context.Areas.Remove(oObjetoX);
            context.SaveChanges();
            return;
        }

        public bool EliminarArea(Area area)
        {
            context.Areas.Remove(area);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public Area ObtenerArea(int id)
        {
            return this.context.Areas.Find(id);
            throw new NotImplementedException();
        }

        public IEnumerable<Area> ObtenerAreas()
        {
            var areas = this.context.Areas.AsNoTracking().ToList();
            return areas;
        }

        public IEnumerable<Area> ObtenerAreasByFiltering(string TextoAbuscar)
        {
            using (LaESapERPContext  db = new LaESapERPContext() )
            {
                var areas = db.Areas.Where(i => DbFunctions.Like(i.Nombre, "%"+TextoAbuscar+"%" ))
                    .ToList();
                return areas;
            }
        }





    }
}
