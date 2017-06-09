using ClinicaMedica.Controller;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncionarioConsultar : Form
    {
        public FrmFuncionarioConsultar()
        {
            InitializeComponent();
        }

        private void FrmFuncionarioConsultar_Load(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = new FuncionarioController().Select();
        }
    }
}
