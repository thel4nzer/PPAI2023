using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using PPAI_2023.Datos;
using PPAI_2023.Iterador;

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
            RespuestaPosible resPosible1 = new RespuestaPosible(24, "No, me van a robar",1);
            RespuestaPosible resPosible2 = new RespuestaPosible(5, "Delincuente",2);
            RespuestaPosible resPosible3 = new RespuestaPosible(1, "Robame todo 5544 5533 3344 5667",3);
            RespuestaPosible resPosible4 = new RespuestaPosible(8, "",4);
            RespuestaPosible resPosible5 = new RespuestaPosible(9, "",5);
            RespuestaPosible resPosible6 = new RespuestaPosible(11, "",6);
            RespuestaPosible resPosible7 = new RespuestaPosible(99, "",7);

            respuestaPosibles = new List<RespuestaPosible>() {resPosible1, resPosible2, resPosible3, resPosible4, resPosible5, resPosible6, resPosible7};

            //Respuestas de Clientes
            RespuestaCliente resp1 = new RespuestaCliente(new DateTime(22, 06, 14, 14, 00, 0), resPosible1);
            RespuestaCliente resp2 = new RespuestaCliente(new DateTime(22, 06, 14, 14, 00, 0), resPosible2);
            RespuestaCliente resp3 = new RespuestaCliente(new DateTime(22, 06, 14, 14, 00, 0), resPosible3);

            respuestaClientes = new List<RespuestaCliente>() { resp1, resp2, resp3};

            //Estados
            Estado estado1 = new Estado("Iniciada", 1);
            Estado estado2 = new Estado("Estado2",3);
            Estado estado3 = new Estado("Estado3",4);
            Estado estado4 = new Estado("Estado4",5);
            Estado estado5 = new Estado("Finalizado",2);
            Estado estado6 = new Estado("Estado6",6);

            estados = new List<Estado>() { estado1, estado2, estado3, estado4, estado5, estado6 };

            //Clientes
            Cliente cliente1 = new Cliente(43601729, "Ivar Jacobson", "357132790");
            Cliente cliente2 = new Cliente(35608721, "German Velez", "351435872");
            Cliente cliente3 = new Cliente(55321822, "Marcela Cattaneo", "011456819");

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
            Pregunta preg1 = new Pregunta("Me da los datos de su tarjeta??", 1);
            Pregunta preg2 = new Pregunta("Su banco lo esta financiando bien?",2);

            preguntas = new List<Pregunta>() { preg1, preg2};

            //Encuestas
            Encuesta encuesta1 = new Encuesta("Le gusto o no???", new DateTime(2022, 06, 16, 14, 00, 0), 1);
            encuesta1.agregarPregunta(preg1);
            Encuesta encuesta2 = new Encuesta("MultipleOPC", new DateTime(2022, 06, 16, 14, 00, 0), 2);
            encuesta2.agregarPregunta(preg2);

            encuestas = new List<Encuesta>() { encuesta1, encuesta2 };

 

            //Cambios de estado Llamada
            Llamada llamada1 = new Llamada(3,"Se hizo el vivo", "Respondio","5 min",true,"Me insulto",cliente1);
            llamada1.agregarCambioDeEstado(cambioEstado1);
            llamada1.agregarCambioDeEstado(cambioEstado2);
            llamada1.agregarCambioDeEstado(cambioEstado3);
            llamada1.agregarRespuestaCliente(resp1);
            Llamada llamada2 = new Llamada(2,"No le pude vender nada", "S/R", "1 min",true,"No quiso pasarse a claro", cliente2);
            llamada2.agregarCambioDeEstado(cambioEstado1);
            llamada2.agregarCambioDeEstado(cambioEstado3);

            Llamada llamada3 = new Llamada(1,"Accedio a contestar", "Respondio", "15 minutos", true, "Lo convencimos", cliente3);
            llamada3.agregarCambioDeEstado(cambioEstado1);
            llamada3.agregarRespuestaCliente(resp3);
            llamadas = new List<Llamada>() { llamada1, llamada2, llamada3};

            



        }

        public List<Encuesta> getEncuesta()
        {
            List<Encuesta> lst = new List<Encuesta>();
            string consultaSQL = "SELECT * FROM ENCUESTAS";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Encuesta a = new Encuesta();
                a.IdEncuesta = Convert.ToInt32(fila["idEncuesta"]);
                a.FechaFinVigencia = Convert.ToDateTime(fila["fechaFinVigencia"]);    //fila["Id_Plato"]
                a.Descripcion = fila["descripcion"].ToString();              //fila["NombrePlato"
                string consultaPregunta = "SELECT * FROM PREGUNTAS WHERE idEncuesta = " + a.IdEncuesta; // Asumiendo que hay una columna LlamadaId en CAMBIOESTADO
                DataTable tablaPreguntas = BDHelper.getBDHelper().ConsultaSQL(consultaPregunta);

                foreach (DataRow filaPreguntas in tablaPreguntas.Rows)
                {
                    Pregunta pregunta = new Pregunta();
                    pregunta.Id = Convert.ToInt32(filaPreguntas["idPregunta"]);
                    pregunta.DescripcionPregunta = filaPreguntas["pregunta"].ToString();
                    string consultaRespuestasPosibles = "SELECT * FROM RESPUESTAPOSIBLE WHERE idPregunta = " + pregunta.Id; // Asumiendo que hay una columna LlamadaId en CAMBIOESTADO
                    DataTable tablaRespuestasPosibles = BDHelper.getBDHelper().ConsultaSQL(consultaRespuestasPosibles);

                    foreach (DataRow filaRespuestasPosible in tablaRespuestasPosibles.Rows)
                    {
                        RespuestaPosible c = new RespuestaPosible();
                        c.DescripcionRespuestaP = filaRespuestasPosible["descripcion"].ToString();
                        pregunta.agregarRespuestaPosible(c);
                        
                    }
                    a.Pregunta.Add(pregunta);
                }

                lst.Add(a);

            }
            return lst;
        }

        public List<Llamada> getLlamada()
        {
            List<Llamada> lst = new List<Llamada>();
            string consultaSQL = "SELECT * FROM LLAMADAS";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Llamada a = new Llamada();
                a.Id= Convert.ToInt32(fila["idLlamada"]);
                a.Duracion = Convert.ToString(fila["duracion"]);    //fila["Id_Plato"]
                a.Detalle = fila["detalleAccionRequerida"].ToString();              //fila["NombrePlato"]
                a.DescOperador = fila["descripcionOperador"].ToString();            //fila[DescripcionPlato]
                a.Observacion = Convert.ToString(fila["observacionAutor"]);
                a.Cliente = new Cliente { Dni = Convert.ToInt32(fila["idCliente"]) };
                string consultaCliente = "SELECT * FROM CLIENTES WHERE dni = " + a.Cliente.Dni;
                DataTable tablaCliente = BDHelper.getBDHelper().ConsultaSQL(consultaCliente);

                if (tablaCliente.Rows.Count > 0)
                {
                    a.Cliente.NroCelular = Convert.ToString(tablaCliente.Rows[0]["nroCelular"]);
                    a.Cliente.Nombre = Convert.ToString(tablaCliente.Rows[0]["nombre"]);
                    // Otros datos del cliente, si es necesario
                }
                string consultaCambioEstado = "SELECT * FROM CAMBIOESTADO WHERE idLlamada = " + a.Id; // Asumiendo que hay una columna LlamadaId en CAMBIOESTADO
                DataTable tablaCambioEstado = BDHelper.getBDHelper().ConsultaSQL(consultaCambioEstado);

                foreach (DataRow filaCambioEstado in tablaCambioEstado.Rows)
                {
                    CambioEstado cambioEstado = new CambioEstado();
                    cambioEstado.FechaHoraInicio = Convert.ToDateTime(filaCambioEstado["fechaHoraInicio"]);
                    cambioEstado.Estado = new Estado { Id = Convert.ToInt32(filaCambioEstado["idEstado"])};
                    string consultaEstado = "SELECT * FROM ESTADOS WHERE idEstado = " + cambioEstado.Estado.Id;
                    DataTable tablaEstado = BDHelper.getBDHelper().ConsultaSQL(consultaEstado);

                    if (tablaEstado.Rows.Count > 0)
                    {
                        cambioEstado.Estado.Nombre = Convert.ToString(tablaEstado.Rows[0]["nombre"]);
                        // Otros datos del cliente, si es necesario
                    }
                    a.CambioEstado.Add(cambioEstado);
                }
                string consultaRespuestaCliente = "SELECT * FROM RESPUESTACLIENTE WHERE idLlamada = " + a.Id; // Asumiendo que hay una columna LlamadaId en CAMBIOESTADO
                DataTable tablaRespuestaCliente = BDHelper.getBDHelper().ConsultaSQL(consultaRespuestaCliente);
                foreach (DataRow filaRespuestaCliente in tablaRespuestaCliente.Rows)
                {
                    RespuestaCliente respuestaCliente = new RespuestaCliente();
                    respuestaCliente.FechaEncuestra = Convert.ToDateTime(filaRespuestaCliente["fechaEncuesta"]);
                    respuestaCliente.respuestaSeleccionada = new RespuestaPosible { Id = Convert.ToInt32(filaRespuestaCliente["idRespuestaPosible"]) };
                    string consultaEstado = "SELECT * FROM RESPUESTAPOSIBLE WHERE idRespuestaPosible = " + respuestaCliente.respuestaSeleccionada.Id;
                    DataTable tablaEstado = BDHelper.getBDHelper().ConsultaSQL(consultaEstado);

                    if (tablaEstado.Rows.Count > 0)
                    {
                        respuestaCliente.respuestaSeleccionada.DescripcionRespuestaP = Convert.ToString(tablaEstado.Rows[0]["descripcion"]);
                        // Otros datos del cliente, si es necesario
                    }
                    a.RespuestaCliente.Add(respuestaCliente);
                }
                lst.Add(a);
            }
            return lst;
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
