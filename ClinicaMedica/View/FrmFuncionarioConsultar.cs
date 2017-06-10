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
            CarregarDataGridView();
            mskPesquisa.Focus();
        }

        private void FrmFuncionarioConsultar_Activated(object sender, EventArgs e)
        {
            CarregarDataGridView();
            mskPesquisa.Focus();
        }

        private void mskPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (mskPesquisa.Text.Equals(""))
            {
                CarregarDataGridView();
            }
            else
            {
                if (rbtCodigo.Checked)
                {
                    CarregarDataGridView("CODIGO", mskPesquisa.Text);
                }
                else if (rbtNome.Checked)
                {
                    CarregarDataGridView("NOME", mskPesquisa.Text);
                }
                else
                {
                    CarregarDataGridView("CPF", mskPesquisa.Text);
                }
            }
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodigo.Checked)
            {
                mskPesquisa.ResetText();
                mskPesquisa.Mask = "999999999999";
                mskPesquisa.Focus();
                CarregarDataGridView();
            }
        }

        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNome.Checked)
            {
                mskPesquisa.ResetText();
                mskPesquisa.Mask = "";
                mskPesquisa.Focus();
                CarregarDataGridView();
            }
        }

        private void rbtCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCPF.Checked)
            {
                mskPesquisa.ResetText();
                mskPesquisa.Mask = "000,000,000-00";
                mskPesquisa.Focus();
                CarregarDataGridView();
            }
        }

        private void CarregarDataGridView()
        {
            dgvFuncionarios.DataSource = new FuncionarioController().Select();
            dgvFuncionarios.Columns["Codigo"].HeaderText = "Código";
            dgvFuncionarios.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            dgvFuncionarios.Columns["Funcao"].HeaderText = "Função";
            dgvFuncionarios.Columns["TelefoneResidencial"].HeaderText = "Telefone Residencial";
            dgvFuncionarios.Columns["TelefoneComercial"].HeaderText = "Telefone Comercial";
            dgvFuncionarios.Columns["TelefoneCelular"].HeaderText = "Celular";
            dgvFuncionarios.Columns["Email"].HeaderText = "E-mail";
            dgvFuncionarios.Columns["Endereco"].HeaderText = "Endereço";
            dgvFuncionarios.Columns["Numero"].HeaderText = "Número";
        }

        private void CarregarDataGridView(string filtro, string pesquisa)
        {
            dgvFuncionarios.DataSource = new FuncionarioController().Select(filtro, pesquisa);
            dgvFuncionarios.Columns["Codigo"].HeaderText = "Código";
            dgvFuncionarios.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            dgvFuncionarios.Columns["Funcao"].HeaderText = "Função";
            dgvFuncionarios.Columns["TelefoneResidencial"].HeaderText = "Telefone Residencial";
            dgvFuncionarios.Columns["TelefoneComercial"].HeaderText = "Telefone Comercial";
            dgvFuncionarios.Columns["TelefoneCelular"].HeaderText = "Celular";
            dgvFuncionarios.Columns["Email"].HeaderText = "E-mail";
            dgvFuncionarios.Columns["Endereco"].HeaderText = "Endereço";
            dgvFuncionarios.Columns["Numero"].HeaderText = "Número";
        }
    }
}
