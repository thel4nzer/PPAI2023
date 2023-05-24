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
        private string nombreCompleto;

        private int dni;

        private int nroCelular;

        //Constructor
        public Cliente(int dni, string nombreCompleto, int nroCelular)
        {
            this.nombreCompleto = nombreCompleto;
            this.dni = dni; 
            this.nroCelular = nroCelular;   
        }

        //Propiedades get y set
        public string Nombre { 
            get { return nombreCompleto; } 
            set { nombreCompleto = value; } 
        }

        public int Dni { 
            get { return dni; } 
            set { dni = value; } 
        }

        public int NroCelular { 
            get { return nroCelular; } 
            set { nroCelular = value; } 
        }

        public void(Obtener)

    }
}
