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

        private void dgvMedicos_DoubleClick(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvMedicos.SelectedRows[0].Cells["Codigo"].Value.ToString());
            string nome = dgvMedicos.SelectedRows[0].Cells["Nome"].Value.ToString();
            string cpf = dgvMedicos.SelectedRows[0].Cells["CPF"].Value.ToString();
            string rg = dgvMedicos.SelectedRows[0].Cells["RG"].Value.ToString();
            string crm = dgvMedicos.SelectedRows[0].Cells["CRM"].Value.ToString();
            DateTime dataNascimento = Convert.ToDateTime(dgvMedicos.SelectedRows[0].Cells["DataNascimento"].Value);
            string sexo = dgvMedicos.SelectedRows[0].Cells["Sexo"].Value.ToString();
            string telefoneResidencial = dgvMedicos.SelectedRows[0].Cells["TelefoneResidencial"].Value.ToString();
            string telefoneComercial = dgvMedicos.SelectedRows[0].Cells["TelefoneComercial"].Value.ToString();
            string telefoneCelular = dgvMedicos.SelectedRows[0].Cells["TelefoneCelular"].Value.ToString();
            string email = dgvMedicos.SelectedRows[0].Cells["Email"].Value.ToString();
            string cep = dgvMedicos.SelectedRows[0].Cells["CEP"].Value.ToString();
            string endereco = dgvMedicos.SelectedRows[0].Cells["Endereco"].Value.ToString();
            string numero = dgvMedicos.SelectedRows[0].Cells["Numero"].Value.ToString();
            string complemento = dgvMedicos.SelectedRows[0].Cells["Complemento"].Value.ToString();
            string bairro = dgvMedicos.SelectedRows[0].Cells["Bairro"].Value.ToString();
            string cidade = dgvMedicos.SelectedRows[0].Cells["Cidade"].Value.ToString();
            string estado = dgvMedicos.SelectedRows[0].Cells["Estado"].Value.ToString();

            // FrmMedicoManter frmMedicoManter = new FrmMedicoManter(codigo, nome, cpf, rg, crm, dataNascimento, sexo, telefoneResidencial, telefoneComercial, telefoneCelular, email, cep, endereco, numero, complemento, bairro, cidade, estado);
            // frmMedicoManter.ShowDialog(this);
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