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
        private string descripcionRespuestaP;

        //Constructor
        public RespuestaPosible(int valor, string descripcionRespuestaP)
        {
            this.valor = valor;
            this.descripcionRespuestaP = descripcionRespuestaP;
        }

        //Propiedades get y set
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string DescripcionRespuestaP
        {
            get { return descripcionRespuestaP; }
            set { descripcionRespuestaP = value; }
        }
    }
}
