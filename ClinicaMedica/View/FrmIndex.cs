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

        private void cadastrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPacienteCadastrar frmPacienteCadastrar = new FrmPacienteCadastrar();
            frmPacienteCadastrar.ShowDialog(this);
        }

        private void consultarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPacienteConsultar frmPacienteConsultar = new FrmPacienteConsultar();
            frmPacienteConsultar.ShowDialog(this);
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarioCadastrar frmFuncionarioCadastrar = new FrmFuncionarioCadastrar();
            frmFuncionarioCadastrar.ShowDialog(this);
        }

        private void consultarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarioConsultar frmFuncionarioConsultar = new FrmFuncionarioConsultar();
            frmFuncionarioConsultar.ShowDialog(this);
        }

        private void cadastrarFuncaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncaoCadastrar frmFuncaoCadastrar = new FrmFuncaoCadastrar();
            frmFuncaoCadastrar.ShowDialog(this);
        }

        private void consultarFuncaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncaoConsultar frmFuncaoConsultar = new FrmFuncaoConsultar();
            frmFuncaoConsultar.ShowDialog(this);
        }

        private void cadastrarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicoCadastrar frmMedicoCadastrar = new FrmMedicoCadastrar();
            frmMedicoCadastrar.ShowDialog(this);
        }

        private void consultarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicoConsultar frmMedicoConsultar = new FrmMedicoConsultar();
            frmMedicoConsultar.ShowDialog(this);
        }

        private void cadastrarEspecialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEspecialidadeCadastrar frmEspecialidadeCadastrar = new FrmEspecialidadeCadastrar();
            frmEspecialidadeCadastrar.ShowDialog(this);
        }

        private void consultarEspecialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEspecialidadeConsultar frmEspecialidadeConsultar = new FrmEspecialidadeConsultar();
            frmEspecialidadeConsultar.ShowDialog(this);
        }

        private void cadastrarConsultorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultorioCadastrar frmConsultorioCadastrar = new FrmConsultorioCadastrar();
            frmConsultorioCadastrar.ShowDialog(this);
        }

        private void consultarConsultorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultorioConsultar frmConsultorioConsultar = new FrmConsultorioConsultar();
            frmConsultorioConsultar.ShowDialog(this);
        }

        private void contratarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultorioFuncionarioCadastrar frmConsultorioFuncionarioCadastrar = new FrmConsultorioFuncionarioCadastrar();
            frmConsultorioFuncionarioCadastrar.ShowDialog(this);
        }

        private void consultarQuadroFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultorioFuncionarioConsultar frmConsultorioFuncionarioConsultar = new FrmConsultorioFuncionarioConsultar();
            frmConsultorioFuncionarioConsultar.ShowDialog(this);
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaGerenciar frmConsultaGerenciar = new FrmConsultaGerenciar();
            frmConsultaGerenciar.ShowDialog(this);
        }

        private void cadastrarExameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExameCadastrar frmExameCadastrar = new FrmExameCadastrar();
            frmExameCadastrar.ShowDialog(this);
        }

        private void consultarExameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExameConsultar frmExameConsultar = new FrmExameConsultar();
            frmExameConsultar.ShowDialog(this);
        }

        private void gerenciarAgendamentoExamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExameGerencia frmExameGerencia = new FrmExameGerencia();
            frmExameGerencia.ShowDialog(this);
        }

        private void consultarAgendamentoExamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExameAgendarConsultar frmExameAgendarConsultar = new FrmExameAgendarConsultar();
            frmExameAgendarConsultar.ShowDialog(this);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}