using System;
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

        private void cadastrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPacienteCadastrar paciente = new FrmPacienteCadastrar();
            paciente.ShowDialog(this);
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarioCadastrar funcionario = new FrmFuncionarioCadastrar();
            funcionario.ShowDialog(this);
        }

        private void cadastrarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicoCadastrar medico = new FrmMedicoCadastrar();
            medico.ShowDialog(this);
        }

        private void cadastrarEspecialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEspecialidadeCadastrar especialidade = new FrmEspecialidadeCadastrar();
            especialidade.ShowDialog(this);
        }

        private void cadastrarFuncaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncaoCadastrar funcao = new FrmFuncaoCadastrar();
            funcao.ShowDialog(this);
        }

        private void especialidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEspecialidadeConsultar espCons = new FrmEspecialidadeConsultar();
            espCons.ShowDialog(this);
        }

        private void funcaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncaoConsultar funcaoCons = new FrmFuncaoConsultar();
            funcaoCons.ShowDialog(this);
        }

        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPacienteConsultar pacienteCons = new FrmPacienteConsultar();
            pacienteCons.ShowDialog(this);
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicoConsultar medicoCons = new FrmMedicoConsultar();
            medicoCons.ShowDialog(this);
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFuncionarioConsultar funcCons = new FrmFuncionarioConsultar();
            funcCons.ShowDialog(this);
        }

        private void exameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmExameConsultar exaCons = new FrmExameConsultar();
            exaCons.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaGerenciar consGerenciar = new FrmConsultaGerenciar();
            consGerenciar.ShowDialog(this);
        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExameGerencia exgere = new FrmExameGerencia();
            exgere.ShowDialog(this);
        }
    }
}