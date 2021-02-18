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
    public class EquiposBL 
    {


        public LaESapERPContext context;

        public EquiposBL()
        {
            context = new LaESapERPContext();
        }
        public bool ActualizarEquipo(Equipo equipo)
        {
            context.Equipos.AddOrUpdate(equipo);
            context.SaveChanges();
            return true;

            throw new NotImplementedException();
        }

        public bool CrearEquipo(Equipo equipo)
        {

            try
            {
                context.Equipos.Add(equipo);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
               //  Console.WriteLine("Exception: " + e.Message);
                throw;
            }
        }

        public void EliminarEquipoByID(int id)
        {
            Equipo oObjetoX = this.context.Equipos.Find(id);
            context.Equipos.Remove(oObjetoX);
            context.SaveChanges();
            return;
        }

        public bool EliminarEquipo(Equipo equipo)
        {
            context.Equipos.Remove(equipo);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public Equipo ObtenerEquipo(int id)
        {
            return this.context.Equipos.Find(id);
            throw new NotImplementedException();
        }

        public IEnumerable<Equipo> ObtenerEquipos()
        {
            var equipos = this.context.Equipos.AsNoTracking().ToList();
            return equipos;
        }


        public IEnumerable<Equipo> ObtenerEquiposByFiltering(string TextoAbuscar, string ColName = "")
        {
            using (LaESapERPContext db = new LaESapERPContext())
            {

                switch (ColName)
                {
                    case "EstadoGarantia":
                        var lstEstadoGarantia = db.Equipos.Where(i => DbFunctions.Like(i.EstadoGarantia, "%" + TextoAbuscar + "%")).ToList();
                        return lstEstadoGarantia;

                    case "ActividadUtilizado":
                        var equiposActivity = db.Equipos.Where(i => DbFunctions.Like(i.ActividadUtilizado, "%" + TextoAbuscar + "%")).ToList();
                        return equiposActivity;

                    case "NombreUsuario":
                        var eq01= db.Equipos.Where(i => DbFunctions.Like(i.NombreUsuario, "%" + TextoAbuscar + "%")).ToList();
                        return eq01;

                    case "NumeroInventarioCPU":
                        var eq02 = db.Equipos.Where(i => DbFunctions.Like(i.NumeroInventarioCPU, "%" + TextoAbuscar + "%")).ToList();
                        return eq02;
                    case "NumeroSerieCPU":
                        var eq03 = db.Equipos.Where(i => DbFunctions.Like(i.NumeroSerieCPU, "%" + TextoAbuscar + "%")).ToList();
                        return eq03;

                    case "MarcaCPU":
                        var eq04 = db.Equipos.Where(i => DbFunctions.Like(i.MarcaCPU, "%" + TextoAbuscar + "%")).ToList();
                        return eq04;

                    case "ModeloCPU":
                        var eq05 = db.Equipos.Where(i => DbFunctions.Like(i.ModeloCPU, "%" + TextoAbuscar + "%")).ToList();
                        return eq05;

                    case "Procesador":
                        var eq06 = db.Equipos.Where(i => DbFunctions.Like(i.Procesador, "%" + TextoAbuscar + "%")).ToList();
                        return eq06;


                    default:
                        var equipos = db.Equipos.Where(i => DbFunctions.Like(i.IdEquipo, "%" + TextoAbuscar + "%"))
                            .ToList();
                        return equipos;
                }


                
            }
        }




    }
}
