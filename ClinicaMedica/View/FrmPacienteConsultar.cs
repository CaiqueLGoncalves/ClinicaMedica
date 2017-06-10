using ClinicaMedica.Controller;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmPacienteConsultar : Form
    {
        public FrmPacienteConsultar()
        {
            InitializeComponent();
        }

        private void FrmPacienteConsultar_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
            mskPesquisa.Focus();
        }

        private void FrmPacienteConsultar_Activated(object sender, EventArgs e)
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

        private void dgvPacientes_DoubleClick(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["Codigo"].Value.ToString());
            string nome = dgvPacientes.SelectedRows[0].Cells["Nome"].Value.ToString();
            string cpf = dgvPacientes.SelectedRows[0].Cells["CPF"].Value.ToString();
            string rg = dgvPacientes.SelectedRows[0].Cells["RG"].Value.ToString();
            DateTime dataNascimento = Convert.ToDateTime(dgvPacientes.SelectedRows[0].Cells["DataNascimento"].Value);
            string sexo = dgvPacientes.SelectedRows[0].Cells["Sexo"].Value.ToString();
            string telefoneResidencial = dgvPacientes.SelectedRows[0].Cells["TelefoneResidencial"].Value.ToString();
            string telefoneComercial = dgvPacientes.SelectedRows[0].Cells["TelefoneComercial"].Value.ToString();
            string telefoneCelular = dgvPacientes.SelectedRows[0].Cells["TelefoneCelular"].Value.ToString();
            string email = dgvPacientes.SelectedRows[0].Cells["Email"].Value.ToString();
            string cep = dgvPacientes.SelectedRows[0].Cells["CEP"].Value.ToString();
            string endereco = dgvPacientes.SelectedRows[0].Cells["Endereco"].Value.ToString();
            string numero = dgvPacientes.SelectedRows[0].Cells["Numero"].Value.ToString();
            string complemento = dgvPacientes.SelectedRows[0].Cells["Complemento"].Value.ToString();
            string bairro = dgvPacientes.SelectedRows[0].Cells["Bairro"].Value.ToString();
            string cidade = dgvPacientes.SelectedRows[0].Cells["Cidade"].Value.ToString();
            string estado = dgvPacientes.SelectedRows[0].Cells["Estado"].Value.ToString();

            FrmPacienteManter frmPacienteManter = new FrmPacienteManter(codigo, nome, cpf, rg, dataNascimento, sexo, telefoneResidencial, telefoneComercial, telefoneCelular, email, cep, endereco, numero, complemento, bairro, cidade, estado);
            frmPacienteManter.ShowDialog(this);
        }

        private void CarregarDataGridView()
        {
            dgvPacientes.DataSource = new PacienteController().Select();
            dgvPacientes.Columns["Codigo"].HeaderText = "Código";
            dgvPacientes.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            dgvPacientes.Columns["TelefoneResidencial"].HeaderText = "Telefone Residencial";
            dgvPacientes.Columns["TelefoneComercial"].HeaderText = "Telefone Comercial";
            dgvPacientes.Columns["TelefoneCelular"].HeaderText = "Celular";
            dgvPacientes.Columns["Email"].HeaderText = "E-mail";
            dgvPacientes.Columns["Endereco"].HeaderText = "Endereço";
            dgvPacientes.Columns["Numero"].HeaderText = "Número";
        }

        private void CarregarDataGridView(string filtro, string pesquisa)
        {
            dgvPacientes.DataSource = new PacienteController().Select(filtro, pesquisa);
            dgvPacientes.Columns["Codigo"].HeaderText = "Código";
            dgvPacientes.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            dgvPacientes.Columns["TelefoneResidencial"].HeaderText = "Telefone Residencial";
            dgvPacientes.Columns["TelefoneComercial"].HeaderText = "Telefone Comercial";
            dgvPacientes.Columns["TelefoneCelular"].HeaderText = "Celular";
            dgvPacientes.Columns["Email"].HeaderText = "E-mail";
            dgvPacientes.Columns["Endereco"].HeaderText = "Endereço";
            dgvPacientes.Columns["Numero"].HeaderText = "Número";
        }
    }
}