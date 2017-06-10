using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncionarioManter : Form
    {
        private int codigo;

        public FrmFuncionarioManter(int codigo, string nome, string cpf, string rg, DateTime dataNascimento, string sexo, string funcao, string telefoneResidencial, string telefoneComercial, string telefoneCelular, string email, string cep, string endereco, string numero, string complemento, string bairro, string cidade, string estado)
        {
            InitializeComponent();

            // Identificação do Funcionário
            this.codigo = codigo;

            // Nome Completo
            txbNome.Text = nome;

            // CPF 
            mskCPF.Text = cpf;

            // RG
            txbRG.Text = rg;

            // Data de Nascimento
            dtpDataNascimento.Value = dataNascimento;

            // Sexo
            if (sexo.Equals("Masculino"))
                rbtMasculino.Checked = true;
            else
                rbtFeminino.Checked = true;

            // Função
            cmbFuncao.SelectedItem = funcao;

            // Telefone Residencial
            mskTelefoneResidencial.Text = telefoneResidencial;

            // Telefone Comercial
            mskTelefoneComercial.Text = telefoneComercial;

            // Telefone Celular
            mskTelefoneCelular.Text = telefoneCelular;

            // E-mail
            txbEmail.Text = email;

            // CEP
            mskCEP.Text = cep;

            // Endereço
            txbEndereco.Text = endereco;

            // Número da Casa
            txbNumero.Text = numero;

            // Complemento
            txbComplemento.Text = complemento;

            // Bairro
            txbBairro.Text = bairro;

            // Cidade
            txbCidade.Text = cidade;

            // Estado
            cmbEstado.SelectedIndex = Utilitario.RetornarIndiceEstado(estado);
        }

        private void FrmFuncionarioManter_Load(object sender, EventArgs e)
        {
            TB_FuncaoTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Funcao);
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(mskCEP.Text);

                txbEndereco.Text = resposta.end;
                txbEndereco.ReadOnly = true;
                txbBairro.Text = resposta.bairro;
                txbBairro.ReadOnly = true;
                txbCidade.Text = resposta.cidade;
                txbCidade.ReadOnly = true;
                cmbEstado.SelectedIndex = Utilitario.RetornarIndiceEstado(resposta.uf);
                cmbEstado.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
