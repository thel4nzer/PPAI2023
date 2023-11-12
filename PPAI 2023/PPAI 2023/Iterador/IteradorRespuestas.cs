using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Iterador
{
    public class IteradorRespuestas : IIteradorSinFiltro<RespuestaCliente>
    {
        private List<RespuestaCliente> respuestas;

        private int indice;


        public IteradorRespuestas(List<RespuestaCliente> respuestas)
        {
            this.respuestas = respuestas ?? throw new ArgumentNullException();
            this.indice = 0;
  

        }

        public void primero()
        {
            if (respuestas.Count == 0)
            {
                //throw new Exception("La coleccion esta vacia.");

            }
           indice = 0;
        }

        public RespuestaCliente actual()
        {
            if (indice < 0 || indice >= respuestas.Count)
            {
                throw new InvalidOperationException("El indice esta fuera de los rangos");
            }
            return respuestas[indice];
        }


        public void siguiente()
        {
            indice++;
        }

        public bool haTerminado()
        {
            return indice >= respuestas.Count;

        }
    }
}
