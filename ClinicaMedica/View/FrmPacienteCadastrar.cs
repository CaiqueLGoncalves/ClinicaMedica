using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmPacienteCadastrar : Form
    {
        public FrmPacienteCadastrar()
        {
            InitializeComponent();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteController pacienteCont = new PacienteController();
                Paciente p = new Paciente();
                Localidade l = new Localidade();

                l.CEP = mskCEP.Text;
                l.Endereco = txbEndereco.Text;
                l.Numero = txbNumero.Text;
                l.Complemento = txbComplemento.Text;
                l.Bairro = txbBairro.Text;
                l.Cidade = txbCidade.Text;
                l.Estado = Utilitario.RetornarSiglaEstado(cmbEstado.SelectedIndex);

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

                var resultado = pacienteCont.Insert(p);

                if (resultado == null)
                {
                    MessageBox.Show("Paciente cadastrado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível cadastrar o paciente!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkCEP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCEP.Checked)
            {
                txbEndereco.ReadOnly = false;
                txbNumero.ReadOnly = false;
                txbComplemento.ReadOnly = false;
                txbBairro.ReadOnly = false;
                txbCidade.ReadOnly = false;
                cmbEstado.Enabled = true;
            }
            else
            {
                txbEndereco.ReadOnly = true;
                txbBairro.ReadOnly = true;
                txbCidade.ReadOnly = true;
                cmbEstado.Enabled = false;
            }
        }
    }
}