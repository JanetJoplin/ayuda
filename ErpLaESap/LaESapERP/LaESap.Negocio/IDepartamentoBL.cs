using LaESap.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Negocio
{
    public interface IDepartamentoBL
    {

        bool CrearDepartamento(Departamento Departamento);
        bool ActualizarDepartamento(Departamento Departamento);
        bool EliminarDepartamentoByID(int id);
        bool EliminarDepartamento(Departamento Departamento);
        Departamento ObtenerDepartamento(int id);
        IEnumerable<Departamento> ObtenerDepartamentos();
        IEnumerable<Departamento> ObtenerDepartamentosByFiltering(string TextoBuscado);
    }
}
