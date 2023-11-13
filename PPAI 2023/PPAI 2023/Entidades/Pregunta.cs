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
        private List<RespuestaPosible> respuestaPosible  = new List<RespuestaPosible>();
        private int idPregunta;
        
        public Pregunta(string descripcionPregunta,int id)
        {
            this.pregunta = descripcionPregunta;
            this.respuestaPosible = new List<RespuestaPosible>();
            this.idPregunta = id;
        }

        public Pregunta()
        {

        }

        // Propiedades get y set
        public string DescripcionPregunta
        {
            get { return pregunta; }
            set { pregunta = value; }
        }

        public int Id
        {
            get { return idPregunta; }
            set { idPregunta = value; }
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

        public void agregarRespuestaPosible(RespuestaPosible re)
        {
            respuestaPosible.Add(re);
        }
    }
}
