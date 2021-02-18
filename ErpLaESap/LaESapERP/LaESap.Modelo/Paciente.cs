using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Modelo
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(100)]
        public string ApellidoPaterno { get; set; }

        [StringLength(100)]
        public string ApellidoMaterno { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public DateTime? FechaNacimiento { get; set; }
        public int? Edad { get; set; }

        [Required]
        public int Estatus { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }

        public DateTime? FechaCambio { get; set; }


    }
}
