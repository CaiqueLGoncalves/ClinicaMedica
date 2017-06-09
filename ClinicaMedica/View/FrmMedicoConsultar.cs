using ClinicaMedica.Controller;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmMedicoConsultar : Form
    {
        public FrmMedicoConsultar()
        {
            InitializeComponent();
        }

        private void FrmMedicoConsultar_Load(object sender, EventArgs e)
        {
            dgvMedicos.DataSource = new MedicoController().Select();
        }
    }
}