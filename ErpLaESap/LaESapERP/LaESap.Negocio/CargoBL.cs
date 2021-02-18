using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaESap.Modelo;
using LaESsap.DAO;

namespace LaESap.Negocio
{

    public class CargoBL : ICargoBl
    {
        public LaESapERPContext context;

        public CargoBL()
        {
            context = new LaESapERPContext();
        }
        public bool ActualizarCargo(Cargo Cargo)
        {
            //context.Cargos(Cargo).state = entitystate.modified; 
            //context.savechanges();
            //return true;
            context.Cargos.AddOrUpdate(Cargo);
            context.SaveChanges();

            var usr = this.context.Cargos.Find(Cargo);
            context.SaveChanges();

            throw new NotImplementedException();
        }

        public bool CrearCargo(Cargo Cargo)
        {

            try
            {
                context.Cargos.Add(Cargo);
                context.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                throw;
            }
            //throw new NotImplementedException();
        }

        public bool EliminarCargo(Cargo Cargo)
        {

            context.Cargos.Remove(Cargo);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public Cargo ObtenerCargo(int id)
        {
            return this.context.Cargos.Find(id);
            throw new NotImplementedException();
        }

        public IEnumerable<Cargo> ObtenerCargos()
        {
            var Cargos = this.context.Cargos.AsNoTracking().ToList();

            return Cargos;

            throw new NotImplementedException();
        }

        public void EliminarCargoByID(int id)
        {
            Cargo oObjetoX = this.context.Cargos.Find(id);
            context.Cargos.Remove(oObjetoX);
            context.SaveChanges();
            return;
        }


        public IEnumerable<Cargo> ObtenerCargosByFiltering(string TextoAbuscar)
        {
            using (LaESapERPContext db = new LaESapERPContext())
            {
                var cargos = db.Cargos.Where(i => DbFunctions.Like(i.Nombre, "%" + TextoAbuscar + "%"))
                    .ToList();
                return cargos;
            }
        }

    }
}
