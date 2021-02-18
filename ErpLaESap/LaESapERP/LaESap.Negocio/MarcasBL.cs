using LaESap.Modelo;
using LaESsap.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Negocio
{

    public class MarcaBL 
    {
    
        
        public LaESapERPContext context;

        public MarcaBL()
        {
            context = new LaESapERPContext();
        }
        public bool ActualizarMarca(Marca marca)
        {
            context.Marcas.AddOrUpdate(marca);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public bool CrearMarca(Marca marca)
        {

            try
            {
//                Prevent duplicates
//                  It you want to check if the association already exists, a cheap query suffices. For example:
        //var exists = db.Categories.Any(c => c.Id == 1 && c.Products.Any(p => p.Id == 14));
                context.Marcas.Add(marca);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                throw;
            }
        }

        public void EliminarMarcaByID(int id)
        {
            Marca oObjetoX =  this.context.Marcas.Find(id);
                    context.Marcas.Remove(oObjetoX);
                    context.SaveChanges();
            return;
        }

        public bool EliminarMarca(Marca marca)
        {
            context.Marcas.Remove(marca);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public Marca ObtenerMarca(int id)
        {
            return this.context.Marcas.Find(id);
            throw new NotImplementedException();
        }

        public IEnumerable<Marca> ObtenerMarcas()
        {
            var marcas = this.context.Marcas.AsNoTracking().ToList();
            return marcas;
        }



    }


}

