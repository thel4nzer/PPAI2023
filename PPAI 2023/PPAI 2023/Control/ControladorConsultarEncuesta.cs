using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Control
{
    public class ControladorConsultarEncuesta
    {
        //Atributos
        private PantallaConsultarEncuesta pantalla;
        private Encuesta encuesta;
        private Llamada llamada;
        private List<Llamada> datosLlamada;
        private GeneradorDeDatos generadorDatos;

        public ControladorConsultarEncuesta(PantallaConsultarEncuesta pantalla)
        {
            this.pantalla = pantalla;
            this.generadorDatos = new GeneradorDeDatos();
            this.llamada = new Llamada();
            this.encuesta = new Encuesta();

        }

        public void opcionConsultarEncuesta(PantallaConsultarEncuesta pantalla)
        {
            pantalla.pedirDatosPeriodoLlamada();
        }

        public void tomarDatosPeriodoLlamada(DateTime fechaIni, DateTime fechaFin)
        {
            buscarLlamadas(fechaIni, fechaFin);
        }

        public void buscarLlamadas(DateTime fechaIni, DateTime fechaFin)
        {
            List<Llamada> llam = generadorDatos.getLlamadas();
            datosLlamada = new List<Llamada>();
            for (int i = 0; i < llam.Count(); i++)
            {
                if (llam[i].esDePeriodo(fechaIni, fechaFin))
                {
                    if (llam[i].tieneRespuesta())
                    {
                        datosLlamada.Add(llam[i]);
                    }
                }
            }
            pantalla.solicitarSeleccionLlamada(datosLlamada);
        }

        public void tomarLlamada(Llamada llamselec)
        {
            obtenerDatosLlamada(llamselec);
            obtenerDatosEncuesta();
            //pantalla.mostrarDatosLlamada();
        }

        public void obtenerDatosLlamada(Llamada llamselec)
        {
            llamada.obtenerDatosLlamada(llamselec);
        }

        public void obtenerDatosEncuesta()
        {
            List<Encuesta> encuestas = generadorDatos.getEncuestas();
            foreach(Encuesta enc in encuestas)
            {
                encuesta.obtenerDatosEncuesta(enc);
            }
        }

    }
}
