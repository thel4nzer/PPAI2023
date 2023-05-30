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
        public Encuesta()
        {

        }

        //Getters & Setters
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

        public void obtenerDatosEncuesta(Encuesta enc)
        {
            List<Pregunta> pregEncuestas = new List<Pregunta>();
            RespuestaPosible resp = new RespuestaPosible();
            foreach (Pregunta preg in enc.pregunta)
            {
                if (preg.esRespuesta(resp))
                {
                    preg.getDescripcion();
                    pregEncuestas.Add(preg);    
                }  
            }
            getDescripcionEncuesta();
        }

        public string getDescripcionEncuesta()
        {
            return descripcion;
        }
    }
}
