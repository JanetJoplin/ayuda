using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Modelo
{
    [Table("Cargos")]
    public class Cargo
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public int Estatus { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }

        public DateTime? FechaCambio { get; set; }

        //[Required]
        //public virtual Usuario Usuario { get; set; }
    }
}
