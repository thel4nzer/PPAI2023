using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private int duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;



        public Llamada(string descOperador, string detalle, int duracionLlamada, bool encuestaEnv, string observacion)
        {
            this.descripcionOperador = descOpe
        }
        
            public string descOperador
        {
            get => descOperador;
            set => descOperador = value;
        }

        public string detalle
        {
            get => detalle;
            set => detalle = value;
        }

        public int duracionLlamada
        {
            get => duracionLlamada;
            set => duracionLlamada = value;
        }

        public bool encuestaEnv
        {
            get => encuestaEnv;
            set => encuestaEnv = value;
        }
    } 
            
}

    

