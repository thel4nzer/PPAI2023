using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Usuario
    {
        //Atributos
        private string nombreUsuario;
        private string contrasena;
        private DateTime fechaAlta;
        private Boolean activo;


        //Constructor
        public Usuario(string nomUsu, string contra, DateTime fechaA, Boolean act ) 
        {
            this.nombreUsuario = nomUsu;
            this.contrasena = contra;
            this.fechaAlta = fechaA;
            this.activo = act;

        }

        //Métodos get set
        public string nombreUsu
        {
            get => nombreUsuario;
            set => nombreUsuario = value;
        }

        public string contra
        {
            get => contrasena;
            set => contrasena = value;
        }

        public DateTime fechaDeAlta
        {
            get => fechaAlta;
            set => fechaAlta = value;
        }

        public Boolean valorActivo
        {
            get => activo;
            set => activo = value;
        }



    }


}
