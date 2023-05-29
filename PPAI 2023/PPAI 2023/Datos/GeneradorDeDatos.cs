using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PPAI_2023
{
    public class GeneradorDeDatos
    {
        private List<Estado> estados;
        private List<CambioEstado> cambioEstado;
        private List<Llamada> llamadas;
        private List<Cliente> clientes;
        private List<RespuestaCliente> respuestaClientes;
        private List<RespuestaPosible> respuestaPosibles;
        private List<Encuesta> encuestas;
        private List<Pregunta> preguntas;

        public GeneradorDeDatos()
        {
            



            //RespuestaPosible
            RespuestaPosible resPosible1 = new RespuestaPosible(24, "No, me van a robar");
            RespuestaPosible resPosible2 = new RespuestaPosible(5, "Delincuente");
            RespuestaPosible resPosible3 = new RespuestaPosible(1, "Robame todo 5544 5533 3344 5667");
            RespuestaPosible resPosible4 = new RespuestaPosible(8, "");
            RespuestaPosible resPosible5 = new RespuestaPosible(9, "");
            RespuestaPosible resPosible6 = new RespuestaPosible(11, "");
            RespuestaPosible resPosible7 = new RespuestaPosible(99, "");

            respuestaPosibles = new List<RespuestaPosible>() {resPosible1, resPosible2, resPosible3, resPosible4, resPosible5, resPosible6, resPosible7};

            //Respuestas de Clientes
            RespuestaCliente resp1 = new RespuestaCliente(new DateTime(22, 06, 14, 14, 00, 0), resPosible1);
            RespuestaCliente resp2 = new RespuestaCliente(new DateTime(22, 06, 14, 14, 00, 0), resPosible2);
            RespuestaCliente resp3 = new RespuestaCliente(new DateTime(22, 06, 14, 14, 00, 0), resPosible3);

            respuestaClientes = new List<RespuestaCliente>() { resp1, resp2, resp3};

            //Estados
            Estado estado1 = new Estado("Iniciada");
            Estado estado2 = new Estado("Estado2");
            Estado estado3 = new Estado("Estado3");
            Estado estado4 = new Estado("Estado4");
            Estado estado5 = new Estado("Finalizado");
            Estado estado6 = new Estado("Estado6");

            estados = new List<Estado>() { estado1, estado2, estado3, estado4, estado5, estado6 };

            //Clientes
            Cliente cliente1 = new Cliente(43601729, "Ivar Jacobson", 357132790);
            Cliente cliente2 = new Cliente(35608721, "German Velez", 351435872);
            Cliente cliente3 = new Cliente(55321822, "Marcela Cattaneo", 011456819);

            clientes = new List<Cliente>() { cliente1, cliente2, cliente3 };

            //Cambios de Estado de Llamada (uno por llamada)
            CambioEstado cambioEstado1 = new CambioEstado(new DateTime(2022, 06, 14, 14, 00, 0), estado1);
            CambioEstado cambioEstado2 = new CambioEstado(new DateTime(2023, 06, 14, 14, 00, 0), estado4);
            CambioEstado cambioEstado3 = new CambioEstado(new DateTime(2024, 06, 14, 14, 00, 0), estado5);
            CambioEstado cambioEstado4 = new CambioEstado(new DateTime(2022, 06, 14, 14, 00, 0), estado5);
            CambioEstado cambioEstado5 = new CambioEstado(new DateTime(2022, 06, 14, 14, 00, 0), estado6);
            CambioEstado cambioEstado6 = new CambioEstado(new DateTime(2022, 06, 14, 14, 00, 0), estado6);
            CambioEstado cambioEstado7 = new CambioEstado(new DateTime(2022, 06, 14, 14, 00, 0), estado4);
            CambioEstado cambioEstado8 = new CambioEstado(new DateTime(2022, 06, 14, 14, 00, 0), estado5);
            CambioEstado cambioEstado9 = new CambioEstado(new DateTime(2022, 06, 14, 14, 00, 0), estado6);
            CambioEstado cambioEstado10 = new CambioEstado(new DateTime(2022, 06, 14, 14, 00, 0), estado5);

            cambioEstado = new List<CambioEstado>() { cambioEstado1, cambioEstado2, cambioEstado3, cambioEstado4, cambioEstado5, cambioEstado6, cambioEstado7, cambioEstado8, cambioEstado9, cambioEstado10 };

            //Preguntas
            Pregunta preg1 = new Pregunta("Me da los datos de su tarjeta??");
            Pregunta preg2 = new Pregunta("Su banco lo esta financiando bien?");

            preguntas = new List<Pregunta>() { preg1, preg2};

            //Encuestas
            Encuesta encuesta1 = new Encuesta("Le gusto o no???", new DateTime(2022, 06, 16, 14, 00, 0));
            encuesta1.agregarPregunta(preg1);
            Encuesta encuesta2 = new Encuesta("MultipleOPC", new DateTime(2022, 06, 16, 14, 00, 0));
            encuesta2.agregarPregunta(preg2);

            encuestas = new List<Encuesta>() { encuesta1, encuesta2 };

 

            //Cambios de estado Llamada
            Llamada llamada1 = new Llamada("Se hizo el vivo", "Respondio","5 min",true,"Me puteo",cliente1);
            llamada1.agregarCambioDeEstado(cambioEstado1);
            llamada1.agregarCambioDeEstado(cambioEstado2);
            llamada1.agregarCambioDeEstado(cambioEstado3);
            llamada1.agregarRespuestaCliente(resp1);
            Llamada llamada2 = new Llamada("No le pude vender nada", "S/R", "1 min",true,"No quiso pasarse a claro", cliente2);
            llamada2.agregarCambioDeEstado(cambioEstado1);
            llamada2.agregarCambioDeEstado(cambioEstado3);

            Llamada llamada3 = new Llamada("Accedio a contestar", "Respondio", "15 minutos", true, "Lo convencimos", cliente3);
            llamada3.agregarCambioDeEstado(cambioEstado1);
            llamada3.agregarCambioDeEstado(cambioEstado3);
            llamada3.agregarRespuestaCliente(resp3);
            llamadas = new List<Llamada>() { llamada1, llamada2, llamada3};

        }

        public List<Llamada> getLlamadas()
        {
                return llamadas;
        }

        public List<CambioEstado> getCambiosEstado()
        {
            return cambioEstado;
        }

        public List<Estado> getEstados() 
        {
            return estados;
        }

        public List<Cliente> getClientes() 
        {
            return clientes;
        }

        public List<RespuestaCliente> getRespuestaClientes() 
        {
            return respuestaClientes;
        }

        public List<RespuestaPosible> getRespuestaPosibles()
        {
            return respuestaPosibles;
        }

        public List<Encuesta> getEncuestas()
        {
            return encuestas;
        }
    }
}
