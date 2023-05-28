using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Entidades
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private List<CambioEstado> cambioEstado = new List<CambioEstado>();
        private Cliente cliente;
        private List<RespuestaCliente> respuestaCliente = new List<RespuestaCliente>();
        private string duracion;

        public Llamada(string descOperador, string detalle, string duracion, bool encuestaEnv, string observacion, Cliente cliente)
        {
            this.descripcionOperador = descOperador;
            this.detalleAccionRequerida = detalle;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnv;
            this.observacionAuditor = observacion;
            this.cliente = cliente;
        }

        public Llamada()
        {

        }
        
        public string DescOperador { get => descripcionOperador; set => descripcionOperador = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Detalle { get => detalleAccionRequerida;set => detalleAccionRequerida = value; }
        
        public bool EncuestaEnv { get => encuestaEnviada; set => encuestaEnviada = value; }

        public string Observacion { get => observacionAuditor; set => observacionAuditor = value; } 

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<RespuestaCliente> RespuestaCliente { get => respuestaCliente; set => respuestaCliente = value; }

        public Llamada(string descripcionOperador, string detalleAccionRequerida, bool encuestaEnviada, string observacionAuditor, List<CambioEstado> cambioEstado, Cliente cliente, List<RespuestaCliente> respuestaCliente, string duracion, string descOperador)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.respuestaCliente = respuestaCliente;
            this.duracion = duracion;
            this.cambioEstado = cambioEstado;
            this.cliente = cliente;
            this.cliente = new Cliente();
        }

        public bool esDePeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            for (int i = 0; i < cambioEstado.Count(); i++)
            {
                if (cambioEstado[i].esEstadoInicial())
                {
                    if ((cambioEstado[i].getFechaHoraInicio() >= fechaInicio) && (cambioEstado[i].getFechaHoraInicio() <= fechaFin))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool tieneRespuesta()
        {
            for (int i = 0; i < respuestaCliente.Count(); i++)
            {
                if (respuestaCliente[i].getRespuesta() != "")
                {
                    return true;
                }
            }
            return false;
        }

        //Otros metodos para datos (despues los vemos)

        public void agregarCambioDeEstado(CambioEstado ce)
        {
            cambioEstado.Add(ce);
        }
        public void agregarRespuestaCliente(RespuestaCliente re)
        {
            respuestaCliente.Add(re);
        }

        public string getDuracion(Llamada llamselec)
        {
            return llamselec.duracion;
        }


        public string obtenerDatosLlamada(Llamada llamselec)
        {
            Cliente cliente = llamselec.Cliente;
            cliente.obtenerDatosCliente();
            CambioEstado estadoActual = CambioEstado.ObtenerEstadoActual(llamselec.cambioEstado);

            //CambioEstado estadoActual = llamselec.cambioEstado.OrderByDescending(c => c.FechaHoraInicio).First();
            string estado = estadoActual.getNombreEstado();
            string duracion = getDuracion(llamselec);
            List<string> resp = new List<string>();
            foreach (RespuestaCliente respuesta in llamselec.RespuestaCliente)
            {
                resp.Add(respuesta.obtenerDatosRespuesta());
                // Realiza las operaciones necesarias con cada respuesta
            }
            return estado.ToString();
        }

       

    } 
            
}

    

