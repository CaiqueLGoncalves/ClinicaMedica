using ClinicaMedica.Controller;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmMedicoConsultar : Form
    {
        public FrmMedicoConsultar()
        {
            InitializeComponent();
        }

        private void FrmMedicoConsultar_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
            mskPesquisa.Focus();
        }

        private void FrmMedicoConsultar_Activated(object sender, EventArgs e)
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
                else if (rbtCPF.Checked)
                {
                    CarregarDataGridView("CPF", mskPesquisa.Text);
                }
                else
                {
                    CarregarDataGridView("CRM", mskPesquisa.Text);
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

        private void rbtCRM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCRM.Checked)
            {
                mskPesquisa.ResetText();
                mskPesquisa.Mask = "999999999";
                mskPesquisa.Focus();
                CarregarDataGridView();
            }
        }

        private void CarregarDataGridView()
        {
            dgvMedicos.DataSource = new MedicoController().Select();
            dgvMedicos.Columns["Codigo"].HeaderText = "Código";
            dgvMedicos.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            dgvMedicos.Columns["TelefoneResidencial"].HeaderText = "Telefone Residencial";
            dgvMedicos.Columns["TelefoneComercial"].HeaderText = "Telefone Comercial";
            dgvMedicos.Columns["TelefoneCelular"].HeaderText = "Celular";
            dgvMedicos.Columns["Email"].HeaderText = "E-mail";
            dgvMedicos.Columns["Endereco"].HeaderText = "Endereço";
            dgvMedicos.Columns["Numero"].HeaderText = "Número";
        }

        private void CarregarDataGridView(string filtro, string pesquisa)
        {
            dgvMedicos.DataSource = new MedicoController().Select(filtro, pesquisa);
            dgvMedicos.Columns["Codigo"].HeaderText = "Código";
            dgvMedicos.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            dgvMedicos.Columns["TelefoneResidencial"].HeaderText = "Telefone Residencial";
            dgvMedicos.Columns["TelefoneComercial"].HeaderText = "Telefone Comercial";
            dgvMedicos.Columns["TelefoneCelular"].HeaderText = "Celular";
            dgvMedicos.Columns["Email"].HeaderText = "E-mail";
            dgvMedicos.Columns["Endereco"].HeaderText = "Endereço";
            dgvMedicos.Columns["Numero"].HeaderText = "Número";
        }
    }
}