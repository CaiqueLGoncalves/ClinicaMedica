using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncaoConsultar : Form
    {
        public FrmFuncaoConsultar()
        {
            InitializeComponent();
        }

        private void FrmFuncaoConsultar_Load(object sender, EventArgs e)
        {
            TB_FuncaoTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Funcao);
        }

        private void FrmFuncaoConsultar_Activated(object sender, EventArgs e)
        {
            TB_FuncaoTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Funcao);
        }

        private void txbPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txbPesquisa.Text.Equals(""))
            {
                TBFuncaoBindingSource.RemoveFilter();
            }
            else
            {
                TBFuncaoBindingSource.Filter = "Nome LIKE '%" + txbPesquisa.Text + "%'";
            }
        }
    }
}
