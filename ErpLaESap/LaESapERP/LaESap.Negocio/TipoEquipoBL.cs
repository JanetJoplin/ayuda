using LaESap.Modelo;
using LaESsap.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Negocio
{
    public class TipoEquipoBL
    {


        public LaESapERPContext context;

        public TipoEquipoBL()
        {
            context = new LaESapERPContext();
        }
        public bool ActualizarTipoEquipo(TipoEquipo area)
        {
            context.TipoEquipos.AddOrUpdate(area);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public bool CrearTipoEquipo(TipoEquipo area)
        {

            try
            {
                context.TipoEquipos.Add(area);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                throw;
            }
        }

        public void EliminarTipoEquipoByID(int id)
        {
            TipoEquipo oObjetoX = this.context.TipoEquipos.Find(id);
            context.TipoEquipos.Remove(oObjetoX);
            context.SaveChanges();
            return;
        }

        public bool EliminarTipoEquipo(TipoEquipo area)
        {
            context.TipoEquipos.Remove(area);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public TipoEquipo ObtenerTipoEquipo(int id)
        {
            return this.context.TipoEquipos.Find(id);
            throw new NotImplementedException();
        }

        public IEnumerable<TipoEquipo> ObtenerTipoEquipos()
        {
            var areas = this.context.TipoEquipos.AsNoTracking().ToList();
            return areas;
        }

        public IEnumerable<TipoEquipo> ObtenerTipoEquiposByFiltering(string TextoAbuscar)
        {
            using (LaESapERPContext db = new LaESapERPContext())
            {
                var areas = db.TipoEquipos.Where(i => DbFunctions.Like(i.Nombre, "%" + TextoAbuscar + "%"))
                    .ToList();
                return areas;
            }
        }



    }
}
