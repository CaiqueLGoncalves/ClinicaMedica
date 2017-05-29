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
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void consultórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultorioCadastrar consultorio = new FrmConsultorioCadastrar();
            consultorio.Show();
        }

        private void consultórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultorioConsultar consultorioConsulta = new FrmConsultorioConsultar();
            consultorioConsulta.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoCadastrar produtoCadastra = new FrmProdutoCadastrar();
            produtoCadastra.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstoqueCadastrar estoqueCadastra = new FrmEstoqueCadastrar();
            estoqueCadastra.Show();
        }

        private void produtoEmEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstoqueProdutoCadastrar estoqueProdutoCadastra = new FrmEstoqueProdutoCadastrar();
            estoqueProdutoCadastra.Show();
        }

        private void exameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExameCadastrar exameCadastra = new FrmExameCadastrar();
            exameCadastra.Show();
        }

        private void exameEmConsultóriroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExameConsultorio exameConsultorio = new FrmExameConsultorio();
            exameConsultorio.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPacienteCadastrar paciente = new FrmPacienteCadastrar();
            paciente.ShowDialog(this);
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarioCadastrar funcionario = new FrmFuncionarioCadastrar();
            funcionario.ShowDialog(this);
        }
    }
}
