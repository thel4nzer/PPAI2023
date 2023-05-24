using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    internal class Pregunta
    {
        private string pregunta;
        public Pregunta(string descripcionPregunta)
        {
            this.pregunta = descripcionPregunta;
        }

        // Propiedades get y set
        public string DescripcionPregunta
        {
            get { return descripcionPregunta; }
            set { descripcionPregunta = value; }
        }
    }
}
