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
        private int id;

        //Constructor
        public RespuestaPosible(int valor, string descripcionRespuestaP, int idRespuestaPosible)
        {
            this.valor = valor;
            this.descripcion = descripcionRespuestaP;
            this.id = idRespuestaPosible;
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
        public int Id
        {
            get { return id; }
            set { id = value; }
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
