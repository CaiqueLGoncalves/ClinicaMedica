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

        private void dgvFuncoes_DoubleClick(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvFuncoes.SelectedRows[0].Cells["IdFuncao"].Value.ToString());
            string nome = dgvFuncoes.SelectedRows[0].Cells["Nome"].Value.ToString();
            string descricao = dgvFuncoes.SelectedRows[0].Cells["Descricao"].Value.ToString();

            FrmFuncaoManter frmFuncManter = new FrmFuncaoManter(codigo, nome, descricao);
            frmFuncManter.ShowDialog(this);
        }
    }
}
