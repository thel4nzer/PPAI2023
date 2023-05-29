using PPAI_2023.Control;
using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPAI_2023
{
    public partial class PantallaConsultarEncuesta : Form
    {

        //Atributos
        private ControladorConsultarEncuesta gestor;


        public PantallaConsultarEncuesta()
        {
            habilitarVentana();

        }

        public void habilitarVentana()
        {
            InitializeComponent();

        }

        private void PantallaConsultarEncuesta_Load(object sender, EventArgs e)
        {
            gestor = new ControladorConsultarEncuesta(this);
            gestor.opcionConsultarEncuesta(this);
        }

        public void pedirDatosPeriodoLlamada()
        {
            btnFiltrar.Enabled = true;
        }

        private DateTime tomarFechaInicio()
        {
            return Convert.ToDateTime(maskedFechaInicio.Text);
        }

        private DateTime tomarFechaFin()
        {
            return Convert.ToDateTime(maskedFechaFin.Text);

        }

        public void solicitarSeleccionLlamada(List<Llamada> datosLlamada)
        {
            grdLlamadas.Rows.Clear();
            grdLlamadas.Enabled = true;

            foreach (var llamada in datosLlamada)
            {
                grdLlamadas.AutoGenerateColumns = false;
                grdLlamadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                grdLlamadas.Columns["DescripcionOperadorColumn"].DataPropertyName = "descOperador";
                grdLlamadas.Columns["DuracionColumn"].DataPropertyName = "duracion";
                grdLlamadas.Columns["ObservacionAuditorColum"].DataPropertyName = "observacion";
                //DataGridViewRow fila = new DataGridViewRow();
                //DataGridViewCell celdaAtributo1 = new DataGridViewTextBoxCell();
                //celdaAtributo1.Value = llamada.DescOperador.ToString();
                //fila.Cells.Add(celdaAtributo1);

                //DataGridViewCell celdaAtributo2 = new DataGridViewTextBoxCell();
                //celdaAtributo2.Value = llamada.Duracion.ToString();
                //fila.Cells.Add(celdaAtributo2);

                //DataGridViewCell celdaAtributo3 = new DataGridViewTextBoxCell();
                //celdaAtributo3.Value = llamada.Observacion.ToString();
                //fila.Cells.Add(celdaAtributo3);
                //grdLlamadas.Rows.Add(fila);
                grdLlamadas.DataSource = datosLlamada;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                gestor.tomarDatosPeriodoLlamada(tomarFechaInicio(), tomarFechaFin());
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un rango de fechas valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tomarLlamadaSeleccionada(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSelccionada = grdLlamadas.Rows[e.RowIndex];
                Llamada llamadaSeleccionada = filaSelccionada.DataBoundItem as Llamada;
                gestor.tomarLlamada(llamadaSeleccionada);
                lblDescripcionEncuesta.Visible = true;
                lblDni.Visible = true;
                lblDuracion.Visible = true;
                lblEstado.Visible = true;
                lblnombre.Visible = true;
                lblNroCelular.Visible = true;
            }

        }

        public void mostrarDatosLlamada(string estado, Llamada llamSelec, Encuesta en)
        {
            grdDescripcionRespuestas.Rows.Clear();
            grdDescripcionRespuestas.Columns.Clear();

            lblnombre.Text = llamSelec.Cliente.Nombre.ToString();
            lblDni.Text = llamSelec.Cliente.Dni.ToString();
            lblNroCelular.Text = llamSelec.Cliente.NroCelular.ToString();
            lblDuracion.Text = llamSelec.Duracion.ToString();
            lblEstado.Text = estado.ToString();
            lblDescripcionEncuesta.Text = en.Descripcion.ToString();
            DataGridViewTextBoxColumn descripcionColumn = new DataGridViewTextBoxColumn();
            descripcionColumn.DataPropertyName = "DescripcionRespuesta";
            descripcionColumn.HeaderText = "Descripción";
            descripcionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            grdDescripcionRespuestas.Columns.Add(descripcionColumn);

            foreach (var resp in llamSelec.RespuestaCliente)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(grdDescripcionRespuestas);
                fila.Cells[0].Value = resp.respuestaSeleccionada.DescripcionRespuestaP.ToString();
                grdDescripcionRespuestas.Rows.Add(fila);
            }

            grdRespuestasPosibles.Rows.Clear();
            grdRespuestasPosibles.Columns.Clear();

            DataGridViewTextBoxColumn preguntaColumn = new DataGridViewTextBoxColumn();
            preguntaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            preguntaColumn.DataPropertyName = "Pregunta";
            preguntaColumn.HeaderText = "Pregunta";
            grdRespuestasPosibles.Columns.Add(preguntaColumn);


            foreach (var preg in en.Pregunta)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(grdRespuestasPosibles);
                fila.Cells[0].Value = preg.DescripcionPregunta.ToString();
                grdRespuestasPosibles.Rows.Add(fila);
            }
            btnFiltrar.Enabled = false;
        }

        private void tomarOpcionCsv_Click(object sender, EventArgs e)
        {
            gestor.opcionIngresada(lblnombre.Text, lblEstado.Text, lblDuracion.Text, grdRespuestasPosibles, grdDescripcionRespuestas);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tomarOpcionImprimir_Click(object sender, EventArgs e)
        {
            gestor.opcionImprimir(lblnombre.Text, lblEstado.Text, lblDuracion.Text, grdRespuestasPosibles, grdDescripcionRespuestas);
        }
    }
}