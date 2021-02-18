using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESapERP.Controlador
{
    class Enums
    {


        public enum Propietario
        {
            LAESAP,
            PROVEEDOR
        }


        public enum EstatusTablas { Activo = 0, Inactivo = 1 };

        public enum TipoMantenimiento
        {
            PREVENTIVO,
            CORRECTIVO,
            PREDICTIVO,
            OVERHAULT,
            EN_USO
        }


        public enum ParteRevisar
        {
            ANTIVIRUS,
            DISCO_DURO,
            TARJETA_RED,
            MEMORIA,
            PROCESADOR,
            LIMPIEZA_INTERIOR,
            PROGRAMAS_INSTALADOS
        }


        public enum EstadoEquipo
        {
            NO_INDICADA,
            AC_ACEPTABLE_CONDICIONES,
            RC_REGULAR,
            MC_MALAS_CONDICIONES_ACCION_INMEDIATA
        }


        public enum ActividadesRealizadas
        {
            ACTUALIZAR_ANTIVIRUS,
            VACUNAR_EQUIPO,
            CHEQUEO_DISCO_DURO,
            CHECAR_TARJETA_RED_O_INALAMBRICO,
            CONFIGURAR_MONITOR_MOUSE_TECLADO,
            IMPRESORA
        }



    }
}
