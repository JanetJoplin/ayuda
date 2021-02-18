using System.Collections.Generic;
using LaESap.Modelo;

namespace LaESap.Negocio
{
    public interface ICargoBl
    {
        bool CrearCargo(Cargo Cargo);
        bool ActualizarCargo(Cargo Cargo);
        bool EliminarCargo(Cargo Cargo);
        Cargo ObtenerCargo(int id);
        IEnumerable<Cargo> ObtenerCargos();
        IEnumerable<Cargo> ObtenerCargosByFiltering(string TextoAbuscar);

    }
}
