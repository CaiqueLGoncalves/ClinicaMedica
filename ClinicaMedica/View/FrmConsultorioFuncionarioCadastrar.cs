using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmConsultorioFuncionarioCadastrar : Form
    {
        public FrmConsultorioFuncionarioCadastrar()
        {
            InitializeComponent();
        }

        private void FrmConsultorioFuncionarioCadastrar_Load(object sender, EventArgs e)
        {
            TB_ConsultorioTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Consultorio);
            dgvFuncionario.DataSource = new FuncionarioController().SelectWithMedico();
            dgvFuncionario.Columns["Codigo"].Visible = false;
            dgvFuncionario.Columns["Nome"].HeaderText = "Funcionário";
            dgvFuncionario.Columns["CPF"].Visible = false;
            dgvFuncionario.Columns["RG"].Visible = false;
            dgvFuncionario.Columns["DataNascimento"].Visible = false;
            dgvFuncionario.Columns["Sexo"].Visible = false;
            dgvFuncionario.Columns["Funcao"].HeaderText = "Função";
            dgvFuncionario.Columns["TelefoneResidencial"].Visible = false;
            dgvFuncionario.Columns["TelefoneComercial"].Visible = false;
            dgvFuncionario.Columns["TelefoneCelular"].Visible = false;
            dgvFuncionario.Columns["Email"].Visible = false;
            dgvFuncionario.Columns["CEP"].Visible = false;
            dgvFuncionario.Columns["Endereco"].Visible = false;
            dgvFuncionario.Columns["Numero"].Visible = false;
            dgvFuncionario.Columns["Complemento"].Visible = false;
            dgvFuncionario.Columns["Bairro"].Visible = false;
            dgvFuncionario.Columns["Cidade"].Visible = false;
            dgvFuncionario.Columns["Estado"].Visible = false;
        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
            try
            {
                QuadroFuncionariosController qfCont = new QuadroFuncionariosController();
                QuadroFuncionarios qf = new QuadroFuncionarios();

                qf.IdConsultorio = Convert.ToInt32(cmbConsultorio.SelectedValue);
                qf.IdFuncionario = Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells["Codigo"].Value);
                qf.DataAdmissao = dtpDataAdmissao.Value;
                qf.DataDemissao = null;
                qf.Status = true;

                var resultado = qfCont.Insert(qf);

                if (resultado == null)
                {
                    MessageBox.Show("Funcionário contratado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível contratar o funcionário!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
