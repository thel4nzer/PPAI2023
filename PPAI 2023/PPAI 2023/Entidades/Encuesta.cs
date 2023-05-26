using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Encuesta
    {
        // Atributos
        private string descripcion;
        private DateTime fechaFinVigencia;
        private List<Pregunta> pregunta = new List<Pregunta>();

        // Constructor
        public Encuesta(string descripcion, DateTime fechaFinVigencia)
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
        }

        // Propiedades get y set
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime FechaFinVigencia
        {
            get { return fechaFinVigencia; }
            set { fechaFinVigencia = value; }
        }
        public List<Pregunta> Pregunta { get => pregunta; set => pregunta = value; }

        public Encuesta()
        {

        }

        public void obtenerDatosEncuesta(Encuesta enc)
        {
            List<string> resp = new List<string>();
            foreach (Pregunta preg in enc.pregunta)
            {
                //if(pregunta.esRespuesta());
                // Realiza las operaciones necesarias con cada respuesta
            }
        }
    }
}
