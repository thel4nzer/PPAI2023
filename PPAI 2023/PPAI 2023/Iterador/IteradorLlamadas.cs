using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Iterador
{
    public class IteradorLlamadas: IIterador<Llamada>
    {
        private List<Llamada> llamadas;

        private int indice;

        private List<Func<Llamada, bool>> filtros;


        public IteradorLlamadas(List<Llamada> llamadas, List<Func<Llamada, bool>> filtros = null)
        {
            this.llamadas = llamadas ?? throw new ArgumentNullException();
            this.indice = 0;
            this.filtros = filtros ?? new List<Func<Llamada, bool>>();

        }


        public void primero()
        {
            if(llamadas.Count == 0)
            {
                //throw new Exception("La coleccion esta vacia.");

            }
            indice = 0;
        }

        public Llamada actual() 
        {
            if(indice < 0 || indice >= llamadas.Count)
            {
                throw new InvalidOperationException("El indice esta fuera de los rangos");
            }
            return llamadas[indice];
        }

        public void siguiente()
        {
            indice++;
        }

        public bool haTerminado()
        {
            return indice >= llamadas.Count;

        }

        public bool cumpleFiltro(Func<Llamada, bool> filtro)
        {
            return actual() != null && filtros.Count == 0 || filtros.All(f=> f(actual())) && filtro(actual());
        }
    }
}
