using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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


        public string getNombreEstado()
        {
            return estado.getNombreEstado();
        }
        public static CambioEstado ObtenerEstadoActual(List<CambioEstado> listaCambioEstado)
        {
            CambioEstado estadoActual = listaCambioEstado.OrderByDescending(c => c.getFechaHoraInicio()).First();
            return estadoActual;
        }

        public Dictionary<string, object> obtenerDatosEstado()
        {
            Dictionary<string, object> atributos = new Dictionary<string, object>();
            atributos.Add("Fecha", fechaHoraInicio);
            return atributos;
        }
    }
}
