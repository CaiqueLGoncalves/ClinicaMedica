using ClinicaMedica.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmExameConsultar : Form
    {
        public FrmExameConsultar()
        {
            InitializeComponent();
        }

        private void CarregarDataGridView()
        {
            dtgExame.DataSource = new ExameController().Select();
            dtgExame.Columns["IdExame"].HeaderText = "Código";
            dtgExame.Columns["Nome"].HeaderText = "Nome do Exame";
            dtgExame.Columns["Recomendacoes"].HeaderText = "Recomendações";
        }

        private void CarregarDataGridView(string pesquisa)
        {
            dtgExame.DataSource = new ExameController().Select(pesquisa);
            dtgExame.Columns["IdExame"].HeaderText = "Código";
            dtgExame.Columns["Nome"].HeaderText = "Nome do Exame";
            dtgExame.Columns["Recomendacoes"].HeaderText = "Recomendações";
        }

        private void FrmExameConsultar_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
            txtExame.Focus();
        }

        private void txtExame_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtExame.Text.Equals(""))
            {
                CarregarDataGridView();
            }
            else
                CarregarDataGridView(txtExame.Text);
        }

        private void dtgExame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgExame_DoubleClick(object sender, EventArgs e)
        {
            int idexame = Convert.ToInt32(dtgExame.SelectedRows[0].Cells["IdExame"].Value.ToString());
            string nome = dtgExame.SelectedRows[0].Cells["Nome"].Value.ToString();
            string recomendacoes = dtgExame.SelectedRows[0].Cells["Recomendacoes"].Value.ToString();

            FrmExameManter frmFuncManter = new FrmExameManter(idexame,nome,recomendacoes);
            frmFuncManter.ShowDialog(this);
        }
    }
}
