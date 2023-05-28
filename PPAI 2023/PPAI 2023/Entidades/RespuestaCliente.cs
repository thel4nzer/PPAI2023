using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class RespuestaCliente
    {
        //Atributos
        private DateTime fechaEncuesta;

        public RespuestaPosible respuestaSeleccionada;

        //Constructor
        public RespuestaCliente(DateTime fechaEncuesta, RespuestaPosible respuestaSeleccionada)
        {
            this.fechaEncuesta = fechaEncuesta;
            this.respuestaSeleccionada = respuestaSeleccionada;

        }
        public RespuestaCliente()
        {

        }


        //Propiedades get y set
        public DateTime FechaEncuestra
        {
            get { return fechaEncuesta; }
            set { fechaEncuesta = value; }
        }

        public string getRespuesta()
        {
            return respuestaSeleccionada.getRespuesta();
        }

        public string obtenerDatosRespuesta()
        {
            return respuestaSeleccionada.getRespuesta();
        }


    }
}
