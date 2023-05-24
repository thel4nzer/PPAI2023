using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Estado
    {
        private string nombre;

        public Estado(string nombreEstado)
        {
            this.nombre = nombreEstado;
        }

        public DateTime NombreEstado
        {
            get { return nombreEstado; }
            set { nombreEstado = value; }
        }

        public string getNombreEstado()
        {
            return nombre;
        }
    }
}
