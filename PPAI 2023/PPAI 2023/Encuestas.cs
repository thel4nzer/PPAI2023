using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_2023
{
    public partial class Encuestas : Form
    {
        public Encuestas()
        {
            InitializeComponent();
        }

        private void btnConsultarEncuesta_Click(object sender, EventArgs e)
        {
            PantallaConsultarEncuesta ventana = new PantallaConsultarEncuesta();
            ventana.Show();
            this.Hide();
        }

        private void Encuestas_Load(object sender, EventArgs e)
        {

        }
    }
}
