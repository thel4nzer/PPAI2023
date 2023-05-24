using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class CambioEstado
    {
        // Atributos
        private DateTime fechaHoraInicio;
        private Estado estado;

        // Constructor
        public CambioEstado(DateTime fechaHoraInicio, Estado est)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = est;
        }

        // Propiedades get y set
        public DateTime FechaHoraInicio
        {
            get { return fechaHoraInicio; }
            set { fechaHoraInicio = value; }
        }

        public DateTime getFechaHoraInicio()
        {
            return fechaHoraInicio;
        }

        public bool esEstadoInicial()
        {
            if (estado.getNombreEstado() == "Iniciada")
            {
                return true;
            }
            return false;
        }

    }
}
