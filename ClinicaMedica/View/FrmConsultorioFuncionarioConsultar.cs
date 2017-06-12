using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmConsultorioFuncionarioConsultar : Form
    {
        public FrmConsultorioFuncionarioConsultar()
        {
            InitializeComponent();
        }

        private void FrmConsultorioFuncionarioConsultar_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
            txbPesquisa.Focus();
        }

        private void FrmConsultorioFuncionarioConsultar_Activated(object sender, EventArgs e)
        {
            CarregarDataGridView();
            txbPesquisa.Focus();
        }

        private void txbPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txbPesquisa.Text.Equals(""))
            {
                CarregarDataGridView();
            }
            else
            {
                if (rbtConsultorio.Checked)
                {
                    CarregarDataGridView("CONSULTORIO", txbPesquisa.Text);
                }
                else
                {
                    CarregarDataGridView("FUNCIONARIO", txbPesquisa.Text);
                }
            }
        }

        private void chkFuncionariosInativos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }

        private void rbtConsultorio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtConsultorio.Checked)
            {
                txbPesquisa.ResetText();
                txbPesquisa.Focus();
                CarregarDataGridView();
            }
        }

        private void rbtFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFuncionario.Checked)
            {
                txbPesquisa.ResetText();
                txbPesquisa.Focus();
                CarregarDataGridView();
            }
        }

        private void dgvQuadroFuncionarios_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dgvQuadroFuncionarios.SelectedRows[0].Cells["Status"].Value))
            {
                btnInativar.Enabled = true;
                btnAtivar.Enabled = false;
            }
            else
            {
                btnInativar.Enabled = false;
                btnAtivar.Enabled = true;
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            try
            {
                QuadroFuncionariosController qfCont = new QuadroFuncionariosController();
                QuadroFuncionarios qf = new QuadroFuncionarios();

                qf.IdConsultorio = Convert.ToInt32(dgvQuadroFuncionarios.SelectedRows[0].Cells["IdConsultorio"].Value);
                qf.IdFuncionario = Convert.ToInt32(dgvQuadroFuncionarios.SelectedRows[0].Cells["IdFuncionario"].Value);
                qf.DataAdmissao = Convert.ToDateTime(dgvQuadroFuncionarios.SelectedRows[0].Cells["DataAdmissao"].Value);
                qf.DataDemissao = null;
                qf.Status = true;

                var resultado = qfCont.ChangeStatus(qf);

                if (resultado == null)
                {
                    MessageBox.Show("Cadastro de funcionário ativado no consultório!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridView();
                    txbPesquisa.ResetText();
                    txbPesquisa.Focus();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível ativar este cadastro de funcionário!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            try
            {
                QuadroFuncionariosController qfCont = new QuadroFuncionariosController();
                QuadroFuncionarios qf = new QuadroFuncionarios();

                qf.IdConsultorio = Convert.ToInt32(dgvQuadroFuncionarios.SelectedRows[0].Cells["IdConsultorio"].Value);
                qf.IdFuncionario = Convert.ToInt32(dgvQuadroFuncionarios.SelectedRows[0].Cells["IdFuncionario"].Value);
                qf.DataAdmissao = Convert.ToDateTime(dgvQuadroFuncionarios.SelectedRows[0].Cells["DataAdmissao"].Value);
                qf.DataDemissao = DateTime.Now;
                qf.Status = false;

                var resultado = qfCont.ChangeStatus(qf);

                if (resultado == null)
                {
                    MessageBox.Show("Cadastro de funcionário inativado no consultório!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDataGridView();
                    txbPesquisa.ResetText();
                    txbPesquisa.Focus();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível inativar este cadastro de funcionário!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDataGridView()
        {
            if (chkFuncionariosInativos.Checked)
            {
                dgvQuadroFuncionarios.DataSource = new QuadroFuncionariosController().Select(true);
                dgvQuadroFuncionarios.Columns["DataDemissao"].Visible = true;

            }
            else
            {
                dgvQuadroFuncionarios.DataSource = new QuadroFuncionariosController().Select(false);
                dgvQuadroFuncionarios.Columns["DataDemissao"].Visible = false;
            }

            dgvQuadroFuncionarios.Columns["Consultorio"].HeaderText = "Consultório";
            dgvQuadroFuncionarios.Columns["Funcionario"].HeaderText = "Funcionário";
            dgvQuadroFuncionarios.Columns["FuncFuncao"].HeaderText = "Função";
            dgvQuadroFuncionarios.Columns["DataAdmissao"].HeaderText = "Data de Admissão";
            dgvQuadroFuncionarios.Columns["DataDemissao"].HeaderText = "Data de Demissão";
            dgvQuadroFuncionarios.Columns["Status"].Visible = false;
            dgvQuadroFuncionarios.Columns["IdConsultorio"].Visible = false;
            dgvQuadroFuncionarios.Columns["IdFuncionario"].Visible = false;

        }

        private void CarregarDataGridView(string filtro, string pesquisa)
        {
            if (chkFuncionariosInativos.Checked)
            {
                dgvQuadroFuncionarios.DataSource = new QuadroFuncionariosController().Select(filtro, pesquisa, true);
                dgvQuadroFuncionarios.Columns["DataDemissao"].Visible = true;

            }
            else
            {
                dgvQuadroFuncionarios.DataSource = new QuadroFuncionariosController().Select(filtro, pesquisa, false);
                dgvQuadroFuncionarios.Columns["DataDemissao"].Visible = false;
            }

            dgvQuadroFuncionarios.Columns["Consultorio"].HeaderText = "Consultório";
            dgvQuadroFuncionarios.Columns["Funcionario"].HeaderText = "Funcionário";
            dgvQuadroFuncionarios.Columns["FuncFuncao"].HeaderText = "Função";
            dgvQuadroFuncionarios.Columns["DataAdmissao"].HeaderText = "Data de Admissão";
            dgvQuadroFuncionarios.Columns["DataDemissao"].HeaderText = "Data de Demissão";
            dgvQuadroFuncionarios.Columns["Status"].Visible = false;
            dgvQuadroFuncionarios.Columns["IdConsultorio"].Visible = false;
            dgvQuadroFuncionarios.Columns["IdFuncionario"].Visible = false;
        }
    }
}
