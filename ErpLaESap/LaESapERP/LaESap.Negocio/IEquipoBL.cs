using System;
using System.Collections.Generic;
using LaESap.Modelo;


namespace LaESap.Negocio
{
    public interface IEquipoBL      // zzequipos
    
    {
        bool CrearEquipo(Equipo Equipo);
        bool ActualizarEquipo(Equipo Equipo);
        bool EliminarEquipoByID(int id);
        bool EliminarEquipo(Equipo Equipo);

        Equipo ObtenerEquipo(int id);
        IEnumerable<Equipo> ObtenerEquipos();
        IEnumerable<Equipo> ObtenerEquiposByFiltering(string TextoAbuscar);

    }
}
