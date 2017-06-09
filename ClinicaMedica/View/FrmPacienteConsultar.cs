using ClinicaMedica.Controller;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmPacienteConsultar : Form
    {
        public FrmPacienteConsultar()
        {
            InitializeComponent();
        }

        private void FrmPacienteConsultar_Load(object sender, System.EventArgs e)
        {
            dgvPacientes.DataSource = new PacienteController().Select();
        }
    }
}
