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

        
        public string getNombreEstado()
        {
            return nombre;
        }
    }
}
