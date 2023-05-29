using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using static System.Net.WebRequestMethods;

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
            string estado=obtenerDatosLlamada(llamselec);
            Encuesta enc = obtenerDatosEncuesta();
            pantalla.mostrarDatosLlamada(estado, llamselec, enc);
        }

        public string obtenerDatosLlamada(Llamada llamselec)
        {
            return llamada.obtenerDatosLlamada(llamselec);
        }

        public Encuesta obtenerDatosEncuesta()
        {
            Encuesta en = new Encuesta();
            List<Encuesta> encuestas = generadorDatos.getEncuestas();
            foreach(Encuesta enc in encuestas)
            {
                en = encuesta.obtenerDatosEncuesta(enc);
            }
            return en;
        }

        public void opcionIngresada(string nombre, string estado, string duracion, System.Windows.Forms.DataGridView grdPreguntas, System.Windows.Forms.DataGridView grdRespuestas)
        {
            generarCsv(nombre, estado, duracion, grdPreguntas, grdRespuestas);
            finCU();
        }

        public void opcionImprimir(string nombre, string estado, string duracion, System.Windows.Forms.DataGridView grdPreguntas, System.Windows.Forms.DataGridView grdRespuestas)
        {
            imprimir(nombre, estado, duracion, grdPreguntas, grdRespuestas);
            finCU();
        }

        public void imprimir(string nombre, string estado, string duracion, DataGridView grdPreguntas, DataGridView grdRespuestas)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += (sender, e) =>
            {
                // Establecer la configuración de la página
                Margins margins = new Margins(50, 50, 50, 50);
                document.DefaultPageSettings.Margins = margins;
                int x = margins.Left;
                int y = margins.Top;

                // Imprimir los encabezados
                Font headerFont = new Font("Arial", 12, FontStyle.Bold);
                e.Graphics.DrawString("Cliente: " + nombre, headerFont, Brushes.Black, x, y);
                y += (int)headerFont.GetHeight();

                e.Graphics.DrawString("Estado: " + estado, headerFont, Brushes.Black, x, y);
                y += (int)headerFont.GetHeight();

                e.Graphics.DrawString("Duración: " + duracion, headerFont, Brushes.Black, x, y);
                y += (int)headerFont.GetHeight() * 2;

                // Imprimir las preguntas
                Font questionFont = new Font("Arial", 10);
                foreach (DataGridViewRow row in grdPreguntas.Rows)
                {
                    string pregunta = row.Cells[0].Value?.ToString();
                    e.Graphics.DrawString(pregunta, questionFont, Brushes.Black, x, y);
                    y += (int)questionFont.GetHeight();
                }

                y += (int)questionFont.GetHeight();

                // Imprimir las respuestas
                Font answerFont = new Font("Arial", 10, FontStyle.Bold);
                foreach (DataGridViewRow row in grdRespuestas.Rows)
                {
                    string respuesta = row.Cells[0].Value?.ToString();
                    e.Graphics.DrawString(respuesta, answerFont, Brushes.Black, x, y);
                    y += (int)answerFont.GetHeight();
                }
            };

            // Mostrar el diálogo de impresión
            PrintDialog dialog = new PrintDialog();
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        public void finCU()
        {
            pantalla.Close();
        }

        public void generarCsv(string nombre, string estado, string duracion, System.Windows.Forms.DataGridView grdPreguntas, System.Windows.Forms.DataGridView grdRespuestas)
        {
            string nombreCliente = nombre;
            string estadoActual = estado;
            string duracionActual = duracion;

            // Ruta del archivo CSV
            string rutaArchivo = "C:\\Users\\Usuario\\Desktop\\datos.csv";

            // Verificar si el archivo existe
            bool archivoExistente = System.IO.File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, append: true))
            {
                // Escribir los encabezados solo si el archivo no existe previamente
                if (!archivoExistente)
                {
                    writer.WriteLine("Cliente,Estado,Duración");
                    writer.WriteLine($"{nombreCliente}, {estadoActual}, {duracionActual}");
                    writer.WriteLine("Preguntas, Respuestas");
                    int rowCount = Math.Max(grdPreguntas.Rows.Count, grdRespuestas.Rows.Count);

                    for (int i = 0; i < rowCount; i++)
                    {
                        string pregunta = (i < grdPreguntas.Rows.Count) ? grdPreguntas.Rows[i].Cells[0].Value?.ToString() : "";
                        string respuesta = (i < grdRespuestas.Rows.Count) ? grdRespuestas.Rows[i].Cells[0].Value?.ToString() : "";

                        writer.WriteLine($"{pregunta},{respuesta}");
                    }
                }
            }

            MessageBox.Show("CSV GENERADO CORRECTAMENTE", "CSV EXITOSO");
        }
    }
}
