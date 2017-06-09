using ClinicaMedica.Controller;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmPacienteConsultar : Form
    {
        public FrmPacienteConsultar()
        {
            InitializeComponent();
        }

        private void FrmPacienteConsultar_Load(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = new PacienteController().Select();
        }
    }
}
