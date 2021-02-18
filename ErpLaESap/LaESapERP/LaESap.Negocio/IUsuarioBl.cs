using System.Collections.Generic;
using LaESap.Modelo;

namespace LaESap.Negocio
{
    public interface IUsuarioBl 
    { 
        bool CrearUsuario(Usuario usuario);
        bool ActualizarUsuario(Usuario usuario);
        bool EliminarUsuario(Usuario usuario);
        void EliminarUsuarioByID(int id);
        Usuario ObtenerUsuario(int id);
        IEnumerable<Usuario> ObtenerUsuarios();
        IEnumerable<Usuario> ObtenerUsuariosByFiltering(string TextoAbuscar);
        
    }
}
