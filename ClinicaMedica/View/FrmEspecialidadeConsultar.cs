using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmEspecialidadeConsultar : Form
    {
        public FrmEspecialidadeConsultar()
        {
            InitializeComponent();
        }

        private void FrmEspecialidadeConsultar_Load(object sender, EventArgs e)
        {
            TB_EspecialidadeTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Especialidade);
        }

        private void FrmEspecialidadeConsultar_Activated(object sender, EventArgs e)
        {
            TB_EspecialidadeTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Especialidade);
        }

        private void txbPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txbPesquisa.Text.Equals(""))
            {
                TBEspecialidadeBindingSource.RemoveFilter();
            }
            else
            {
                TBEspecialidadeBindingSource.Filter = "Nome LIKE '%" + txbPesquisa.Text + "%'";
            }
        }
    }
}
