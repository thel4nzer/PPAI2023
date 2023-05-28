using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class RespuestaPosible
    {
        //Atributos
        private int valor;
        private string descripcion;

        //Constructor
        public RespuestaPosible(int valor, string descripcionRespuestaP)
        {
            this.valor = valor;
            this.descripcion = descripcionRespuestaP;
        }
        public RespuestaPosible()
        {

        }

        //Propiedades get y set
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string DescripcionRespuestaP
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string getRespuesta()
        {
            return descripcion;
        }

    }
   
}
