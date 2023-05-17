using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Cliente
    {
        //Atributos
        private string nombre;

        private string apellido;

        private long dni;

        private long nroCelular;

        //Constructor
        public Cliente(string nombre, string apellido, long dni, long nroCelular)
        {
            this.nombre = nombre;
            this.apellido = apellido;  
            this.dni = dni; 
            this.nroCelular = nroCelular;   
        }

        //Propiedades get y set
        public string Nombre { 
            get { return nombre; } 
            set { nombre = value; } 
        }

        public string Apellido { 
            get { return apellido; } 
            set { apellido = value; } 
        }

        public long Dni { 
            get { return dni; } 
            set { dni = value; } 
        }

        public long NroCelular { 
            get { return nroCelular; } 
            set { nroCelular = value; } 
        }

    }
}
