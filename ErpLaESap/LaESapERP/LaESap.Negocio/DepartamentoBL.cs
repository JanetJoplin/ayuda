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
    public class DepartamentoBL
    {



        public LaESapERPContext context;

        public DepartamentoBL()
        {
            context = new LaESapERPContext();
        }
        public bool ActualizarDepartamento(Departamento depto)
        {
            context.Departamentos.AddOrUpdate(depto);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public bool CrearDepartamento(Departamento depto)
        {

            try
            {
                context.Departamentos.Add(depto);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                throw;
            }
        }

        public void EliminarDepartamentoByID(int id)
        {
            Departamento oObjetoX = this.context.Departamentos.Find(id);
            context.Departamentos.Remove(oObjetoX);
            context.SaveChanges();
            return;
        }

        public bool EliminarDepartamento(Departamento depto)
        {
            context.Departamentos.Remove(depto);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public Departamento ObtenerDepartamento(int id)
        {
            return this.context.Departamentos.Find(id);
            throw new NotImplementedException();
        }

        public IEnumerable<Departamento> ObtenerDepartamentos()
        {
            var areas = this.context.Departamentos.AsNoTracking().ToList();
            return areas;
        }

        public IEnumerable<Departamento> ObtenerDepartamentosByFiltering(string TextoAbuscar)
        {
            using (LaESapERPContext db = new LaESapERPContext())
            {
                var areas = db.Departamentos.Where(i => DbFunctions.Like(i.Nombre, "%" + TextoAbuscar + "%"))
                    .ToList();
                return areas;
            }
        }




    }
}
