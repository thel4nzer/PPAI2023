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

        private int id;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public Estado(string nombre, int id)
        {
            this.Nombre = nombre;       
            this.Id = id;
        }

        public Estado() { }

        public string getNombreEstado()
        {
            return nombre;
        }


    }
}
