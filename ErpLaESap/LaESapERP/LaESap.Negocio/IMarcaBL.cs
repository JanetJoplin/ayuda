using System.Collections.Generic;
using LaESap.Modelo;

namespace LaESap.Negocio
{
    public interface IMarcaBL
    {
        bool CrearMarca(Marca Marca);
        bool ActualizarMarca(Marca Marca);
        bool EliminarMarcaByID(int id);
        bool EliminarMarca(Marca Marca);
        Marca ObtenerMarca(int id);
        IEnumerable<Marca> ObtenerMarcas();
    }
}
