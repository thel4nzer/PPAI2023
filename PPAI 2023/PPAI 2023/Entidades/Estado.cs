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

        public string Nombre { get => nombre; set => nombre = value; }

        public Estado(string nombre)
        {
            this.Nombre = nombre;       
        }

        public string getNombreEstado()
        {
            return nombre;
        }


    }
}
