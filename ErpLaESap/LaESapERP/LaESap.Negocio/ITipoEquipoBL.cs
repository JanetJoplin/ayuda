using LaESap.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Negocio
{
    public interface ITipoEquipoBL
    {

        bool CrearTipoEquipo(TipoEquipo TipoEquipo);
        bool ActualizarTipoEquipo(TipoEquipo TipoEquipo);
        bool EliminarTipoEquipoByID(int id);
        bool EliminarTipoEquipo(TipoEquipo TipoEquipo);
        TipoEquipo ObtenerTipoEquipo(int id);
        IEnumerable<TipoEquipo> ObtenerTipoEquipos();
        IEnumerable<TipoEquipo> ObtenerTipoEquiposByFiltering(string TextoBuscado);

    }
}
