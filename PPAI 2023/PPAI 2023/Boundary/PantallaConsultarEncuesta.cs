using PPAI_2023.Control;
using PPAI_2023.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            grdLlamadas.Enabled = true;
            foreach (var llamada in datosLlamada)
            {
                grdLlamadas.AutoGenerateColumns = false;
                grdLlamadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                grdLlamadas.Columns.Add("DescripcionOperadorColumn", "Descripcion Operador");
                grdLlamadas.Columns.Add("DuracionColumn", "Duracion");
                grdLlamadas.Columns.Add("ObservacionAuditorColum", "Observacion Auditor");

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
            gestor.tomarDatosPeriodoLlamada(tomarFechaInicio(), tomarFechaFin());
        }

        private void tomarLlamadaSeleccionada(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSelccionada = grdLlamadas.Rows[e.RowIndex];
                Llamada llamadaSeleccionada = filaSelccionada.DataBoundItem as Llamada;
                gestor.tomarLlamada(llamadaSeleccionada);
            }

        }

        public void mostrarDatosLlamada()
        {
            //lblnombre.Text= 
            //lblDni.Text=
            //lblNroCelular.Text=
        }
    }
}
