using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Modelo
{

    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }   // nombre completo

        [Required]
        public int Estatus { get; set; }  // 0-inactivo 1=activo

        [Required]
        [StringLength(100)]
        public string Login { get; set; }  // usuario con el que se conecta

        [StringLength(200)]
        public string Password { get; set; }


        [StringLength(200)]
        public string CorreoElectronico { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaCambio { get; set; }


        public int CargoId { get; set; }
        public virtual Cargo Cargo { get; set; }
    }

}
