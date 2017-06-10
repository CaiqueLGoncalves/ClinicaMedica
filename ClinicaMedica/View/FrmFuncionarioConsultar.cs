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

        private void dgvFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells["Codigo"].Value.ToString());
            string nome = dgvFuncionarios.SelectedRows[0].Cells["Nome"].Value.ToString();
            string cpf = dgvFuncionarios.SelectedRows[0].Cells["CPF"].Value.ToString();
            string rg = dgvFuncionarios.SelectedRows[0].Cells["RG"].Value.ToString();
            DateTime dataNascimento = Convert.ToDateTime(dgvFuncionarios.SelectedRows[0].Cells["DataNascimento"].Value);
            string sexo = dgvFuncionarios.SelectedRows[0].Cells["Sexo"].Value.ToString();
            string funcao = dgvFuncionarios.SelectedRows[0].Cells["Funcao"].Value.ToString();
            string telefoneResidencial = dgvFuncionarios.SelectedRows[0].Cells["TelefoneResidencial"].Value.ToString();
            string telefoneComercial = dgvFuncionarios.SelectedRows[0].Cells["TelefoneComercial"].Value.ToString();
            string telefoneCelular = dgvFuncionarios.SelectedRows[0].Cells["TelefoneCelular"].Value.ToString();
            string email = dgvFuncionarios.SelectedRows[0].Cells["Email"].Value.ToString();
            string cep = dgvFuncionarios.SelectedRows[0].Cells["CEP"].Value.ToString();
            string endereco = dgvFuncionarios.SelectedRows[0].Cells["Endereco"].Value.ToString();
            string numero = dgvFuncionarios.SelectedRows[0].Cells["Numero"].Value.ToString();
            string complemento = dgvFuncionarios.SelectedRows[0].Cells["Complemento"].Value.ToString();
            string bairro = dgvFuncionarios.SelectedRows[0].Cells["Bairro"].Value.ToString();
            string cidade = dgvFuncionarios.SelectedRows[0].Cells["Cidade"].Value.ToString();
            string estado = dgvFuncionarios.SelectedRows[0].Cells["Estado"].Value.ToString();

            FrmFuncionarioManter frmFuncManter = new FrmFuncionarioManter(codigo, nome, cpf, rg, dataNascimento, sexo, funcao, telefoneResidencial, telefoneComercial, telefoneCelular, email, cep, endereco, numero, complemento, bairro, cidade, estado);
            frmFuncManter.ShowDialog(this);
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
