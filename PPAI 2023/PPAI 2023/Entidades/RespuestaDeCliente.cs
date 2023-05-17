using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class RespuestaDeCliente
    {
        //Atributos
        private DateTime fechaEncuesta;

        public RespuestaPosible respuestaSeleccionada = new RespuestaPosible();

        //Constructor
        public RespuestaDeCliente(DateTime fechaEncuesta)
        {
            this.fechaEncuesta = fechaEncuesta;
         
        }

        //Propiedades get y set
        public DateTime FechaEncuestra
        {
            get { return fechaEncuesta; }
            set { fechaEncuesta = value; }
        }
    }
}
