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

    public class UsuarioBL : IUsuarioBl
    {
        public LaESapERPContext context;

        public UsuarioBL()
        {
            context = new LaESapERPContext();
        }
        public bool ActualizarUsuario(Usuario usuario)
        {
            context.Usuarios.AddOrUpdate(usuario);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public bool CrearUsuario(Usuario usuario)
        {

            try
            {
                   
                context.Usuarios.Add(usuario);
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

        public bool EliminarUsuario(Usuario usuario)
        {

            context.Usuarios.Remove(usuario);
            context.SaveChanges();
            return true;
            throw new NotImplementedException();
        }

        public Usuario ObtenerUsuario(int id)
        {
            return this.context.Usuarios.Find(id);
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            var usuarios = this.context.Usuarios.Include(b => b.Cargo).AsNoTracking().ToList();

            return usuarios;

            throw new NotImplementedException();
        }


        public IEnumerable<Usuario> ObtenerUsuariosByFiltering(string TextoAbuscar)
        {
            using (LaESapERPContext db = new LaESapERPContext())
            {
                var usuario = db.Usuarios.Where(i => DbFunctions.Like(i.Nombre, "%" + TextoAbuscar + "%"))
                    .ToList();

                return usuario;
            }
        }



        public void EliminarUsuarioByID(int id)
        {
            Usuario oObjetoX = this.context.Usuarios.Find(id);
            context.Usuarios.Remove(oObjetoX);
            context.SaveChanges();
            return;
        }

    }
}
