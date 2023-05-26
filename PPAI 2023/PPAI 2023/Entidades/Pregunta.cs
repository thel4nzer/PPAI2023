using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_2023.Entidades
{
    public class Pregunta
    {
        private string pregunta;
        private RespuestaPosible respuestaPosible;
        public Pregunta(string descripcionPregunta, RespuestaPosible respuestaPosible)
        {
            this.pregunta = descripcionPregunta;
            this.respuestaPosible = respuestaPosible;
        }

        // Propiedades get y set
        public string DescripcionPregunta
        {
            get { return pregunta; }
            set { pregunta = value; }
        }

        public bool esRespuesta(RespuestaPosible rta)
        {
            if (respuestaPosible == rta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
