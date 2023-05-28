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
        private List<RespuestaPosible> respuestaPosible;
        
        public Pregunta(string descripcionPregunta, List<RespuestaPosible> respuestaPosible)
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

        public bool esRespuesta(RespuestaPosible resp)
        {
            foreach (RespuestaPosible resPos in respuestaPosible)
            {
                if(resPos == resp)
                return true;
            }
            return false;
        }
        public string getDescripcion()
        {
            return pregunta;
        }
    }
}
