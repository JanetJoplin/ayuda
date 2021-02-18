using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESap.Modelo
{
    public class Equipo //ZZEQUIPOS
    {
        [Key]
        [Required]
        public int Id { get; set; }



        public int TipoEquipoId { get; set; }
        public virtual TipoEquipo TipoEquipo { get; set; }


        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int DepartamentoId { get; set; }
        public virtual Departamento Depto { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }





        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string IdEquipo { get; set; }
        [StringLength(100)]
        public string Departamento { get; set; }
        [StringLength(100)] 
        public string ActividadUtilizado { get; set; }
        [StringLength(100)] 
        public string NombreUsuario { get; set; }
        
        public int? NumeroPersonas { get; set; }
        public DateTime? FechaAdquisicion { get; set; }
        public DateTime? VigenciaGarantia { get; set; }

        [StringLength(100)]
        public string TiempoVida { get; set; }
        public int? ConectadoInternet { get; set; }  // 0-no conectado  1-conectado


        [StringLength(100)]
        public string MantenimientoPreventivo { get; set; }
        [StringLength(100)] 
        public string MantenimientoCorrectivo { get; set; }
        [StringLength(100)]
        public string NumeroInventarioCPU { get; set; }
        [StringLength(100)] 
        public string NumeroSerieCPU { get; set; }
        [StringLength(100)]
        public string MarcaCPU { get; set; }
        [StringLength(100)] 
        public string ModeloCPU { get; set; }
        [StringLength(100)]
        
        public string Procesador { get; set; }
        [StringLength(100)] 
        public string DiscoDuro { get; set; }
        [StringLength(100)]
        public string RAM { get; set; }
        [StringLength(100)]
        public string NumeroInventarioMonitor { get; set; }
        [StringLength(250)] 
        public string NumeroSerieMonitor { get; set; }
        [StringLength(100)] 
        public string MarcaMonitor { get; set; }
        [StringLength(100)] 
        public string ModeloMonitor { get; set; }
        [StringLength(100)] 
        public string PulgadasMonitor { get; set; }
        [StringLength(100)] 
        public string TipoMonitor { get; set; }
        [StringLength(100)] 
        public string NumeroInventarioTeclado { get; set; }
        [StringLength(100)] 
        public string NumeroSerieTeclado { get; set; }
        [StringLength(100)]
        public string MarcaTeclado { get; set; }
        [StringLength(100)] 
        public string ModeloTeclado { get; set; }
        [StringLength(100)] 
        public string NumeroInventarioRaton { get; set; }
        [StringLength(100)] 
        public string NumeroSerieRaton { get; set; }
        [StringLength(100)] 
        public string MarcaRaton { get; set; }
        [StringLength(100)] 
        public string  ModeloRaton { get; set; }



        [StringLength(1000)] 
        public string? NumeroInventarioOtroAccesorio { get; set; }
        [StringLength(100)] 
        public string? NumeroSerieOtroAccesorio { get; set; }
        [StringLength(100)] 
        public string? MarcaOtroAccesorio { get; set; }
        [StringLength(100)] 
        public string? ModeloOtroAccesorio { get; set; }
        
        public DateTime? FechaAdquisiciónOtroAccesorio { get; set; }
        public DateTime? VigenciaGarantiaOtroAccesorio { get; set; }
        [StringLength(100)] 
        public string? TiempoVidaOtroAccesorio { get; set; }
        [StringLength(100)] 
        public string? TipoAccesorio { get; set; }
        [StringLength(100)] 
        public string?  Comentarios { get; set; }
        [StringLength(100)] 
        public string?  DescripcionAccesorio { get; set; }


        [StringLength(100)]
        public string? Password { get; set; }

        [StringLength(100)]
        public string? DireccionIP { get; set; }

        // calculado            update equipo set diasDeVida = DATEDIFF(day,  FechaAdquisicion, GETDATE()  )
        public int? DiasDeVida { get; set; }

        // calculado            update equipo set DiasRestantesGarantia = DATEDIFF(day,  GETDATE() , VigenciaGarantia )
        public int? DiasRestantesGarantia { get; set; }


        public int? EstadoEquipo { get; set; }
        [StringLength(50)]
        public string? EstadoGarantia { get; set; }

        public decimal? AñosDeVida { get; set; }

        [StringLength(250)]
        public string? Condiciones { get; set; }

        public string? Propietario { get; set; }


        public int Estatus { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaCambio { get; set; }

    }
    /*
     
    INSERT INTO Equipo (FechaAlta,Estatus, IdEquipo, Departamento, ActividadUtilizado, NombreUsuario, NumeroPersonas,
	    FechaAdquisicion,VigenciaGarantia,TiempoVida,ConectadoInternet)

        SELECT GETDATE(), 1, ID,   Departamento, Actividad_para_la_que_es_utilizado_el_equipo , 
			    Nombre_del_usuario_del_equipo, N_mero_de_personas_que_usan_el_equipo, 
     CAST(   RIGHT([Fecha_adquisici_n],4)+'-'+SUBSTRING([Fecha_adquisici_n],4,2)+'-'+LEFT([Fecha_adquisici_n],2)    AS DATE) , 
     CAST(   RIGHT(Vigencia_Garant_a,4)+'-'+SUBSTRING(Vigencia_Garant_a,4,2)+'-'+LEFT(Vigencia_Garant_a,2)    AS DATE), 
     Tiempo_de_Vida
     , IIF( LEFT(UPPER(Esta_conectado_a_internet),1)='S', 1, 0)		

	        FROM [LaESapERPConnectionDb].[dbo].[equipos2] 
		

    TRUNCATE TABLE EQUIPO

    CONVERT(VARCHAR, Fecha_adquisici_n  ,101)

    , IIF( LEFT(UPPER(Esta_conectado_a_internet),1)='S', 1,
         */

}
