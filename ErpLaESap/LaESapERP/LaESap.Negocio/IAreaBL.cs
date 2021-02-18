using LaESap.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Negocio
{
    public interface IAreaBL
    {

        bool CrearArea(Area Area);
        bool ActualizarArea(Area Area);
        bool EliminarAreaByID(int id);
        bool EliminarArea(Area Area);
        Area ObtenerArea(int id);
        IEnumerable<Area> ObtenerAreas();
        IEnumerable<Area> ObtenerAreasByFiltering(string TextoBuscado);
    }
}
