using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Modelo
{
    public class Departamento       //ZZDEPTOS
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        //[Index("IdX_Nombre", 1, IsUnique = true)]
        public string Nombre { get; set; }


        [StringLength(20)]
        public string? Clave { get; set; }

        [Required]
        public int Estatus { get; set; }

        [Required]
        
        public DateTime FechaAlta { get; set; }

        public DateTime? FechaCambio { get; set; }

    }
}
