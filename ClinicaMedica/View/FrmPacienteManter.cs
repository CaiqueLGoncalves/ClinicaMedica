using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmPacienteManter : Form
    {
        private int codigo;

        public FrmPacienteManter(int codigo, string nome, string cpf, string rg, DateTime dataNascimento, string sexo, string telefoneResidencial, string telefoneComercial, string telefoneCelular, string email, string cep, string endereco, string numero, string complemento, string bairro, string cidade, string estado)
        {
            InitializeComponent();

            // Identificação do Paciente
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteController pacienteCont = new PacienteController();
                Paciente p = new Paciente();
                Localidade l = new Localidade();

                l.IdLocalidade = pacienteCont.FindLocalidade(codigo).IdLocalidade;
                l.CEP = mskCEP.Text;
                l.Endereco = txbEndereco.Text;
                l.Numero = txbNumero.Text;
                l.Complemento = txbComplemento.Text;
                l.Bairro = txbBairro.Text;
                l.Cidade = txbCidade.Text;
                l.Estado = Utilitario.RetornarSiglaEstado(cmbEstado.SelectedIndex);

                p.Identificacao = codigo;
                p.Nome = txbNome.Text;
                p.CPF = mskCPF.Text;
                p.RG = txbRG.Text;
                p.DataNascimento = dtpDataNascimento.Value;
                p.Sexo = (rbtMasculino.Checked) ? rbtMasculino.Text : rbtFeminino.Text;
                p.TelefoneResidencial = mskTelefoneResidencial.Text;
                p.TelefoneComercial = mskTelefoneResidencial.Text;
                p.TelefoneCelular = mskTelefoneCelular.Text;
                p.Email = txbEmail.Text;
                p.Localidade = l;

                var resultado = pacienteCont.Update(p, l);

                if (resultado == null)
                {
                    MessageBox.Show("Paciente alterado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível alterar o paciente!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteController pacienteCont = new PacienteController();
                Paciente paciente = new Paciente();
                paciente.Identificacao = codigo;

                if (pacienteCont.Delete(paciente))
                {
                    MessageBox.Show("Paciente excluído com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
