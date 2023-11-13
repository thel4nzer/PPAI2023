using PPAI_2023.Iterador;
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
    public class Llamada : IAgregadoSinFiltro<RespuestaCliente>
    {
        private int idLlamada;
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private List<CambioEstado> cambioEstado = new List<CambioEstado>();
        private Cliente cliente;
        private List<RespuestaCliente> respuestaCliente = new List<RespuestaCliente>();
        private string duracion;

        public Llamada(int idLlam, string descOperador, string detalle, string duracion, bool encuestaEnv, string observacion, Cliente cliente)
        {
            this.idLlamada = idLlam;
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
        
        public int Id { get => idLlamada; set => idLlamada = value; }

        public string DescOperador { get => descripcionOperador; set => descripcionOperador = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Detalle { get => detalleAccionRequerida;set => detalleAccionRequerida = value; }
        
        public bool EncuestaEnv { get => encuestaEnviada; set => encuestaEnviada = value; }

        public string Observacion { get => observacionAuditor; set => observacionAuditor = value; } 

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<RespuestaCliente> RespuestaCliente { get => respuestaCliente; set => respuestaCliente = value; }
        public List<CambioEstado> CambioEstado { get => cambioEstado; set => cambioEstado = value; }

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
            IIteradorSinFiltro<RespuestaCliente> iterador = crearIterador(respuestaCliente);
            iterador.primero();

            while (!iterador.haTerminado())
            {
                RespuestaCliente respuestaActual = iterador.actual();

                if (!string.IsNullOrEmpty(respuestaActual.getRespuesta()))
                {
                    // La colección contiene al menos una respuesta no vacía
                    return true;
                }

                iterador.siguiente();
            }

            // Si ninguna respuesta es distinta de vacío
            return false;

            //COMO LO RESOLVIAMOS EN LA ENTREGA ANTERIOR
            //for (int i = 0; i < respuestaCliente.Count(); i++)
            //{
                //if (respuestaCliente[i].getRespuesta() != "")
                //{
                    //return true;
                //}
            //}
            //return false;
        }

        public IIteradorSinFiltro<RespuestaCliente> crearIterador(List<RespuestaCliente>respuestaCliente)
        {
            return new IteradorRespuestas(respuestaCliente);

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
            //CambioEstado estadoActual = CambioEstado.ObtenerEstadoActual(llamselec.CambioEstado);

            CambioEstado estadoActual = llamselec.cambioEstado.OrderByDescending(c => c.FechaHoraInicio).First();
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

    

