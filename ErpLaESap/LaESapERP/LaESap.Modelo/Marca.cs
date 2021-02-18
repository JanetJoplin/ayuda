using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Modelo
{
    public class Marca
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public int Estatus { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }

        public DateTime? FechaCambio { get; set; }


    }
}
