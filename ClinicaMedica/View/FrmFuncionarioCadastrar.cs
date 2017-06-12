using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncionarioCadastrar : Form
    {
        public FrmFuncionarioCadastrar()
        {
            InitializeComponent();
        }

        private void FrmFuncionarioCadastrar_Activated(object sender, EventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioController funcCont = new FuncionarioController();
                Funcionario f = new Funcionario();
                Localidade l = new Localidade();

                l.CEP = mskCEP.Text;
                l.Endereco = txbEndereco.Text;
                l.Numero = txbNumero.Text;
                l.Complemento = txbComplemento.Text;
                l.Bairro = txbBairro.Text;
                l.Cidade = txbCidade.Text;
                l.Estado = Utilitario.RetornarSiglaEstado(cmbEstado.SelectedIndex);

                f.Nome = txbNome.Text;
                f.CPF = mskCPF.Text;
                f.RG = txbRG.Text;
                f.DataNascimento = dtpDataNascimento.Value;
                f.Sexo = (rbtMasculino.Checked) ? rbtMasculino.Text : rbtFeminino.Text;
                f.TelefoneResidencial = mskTelefoneResidencial.Text;
                f.TelefoneComercial = mskTelefoneResidencial.Text;
                f.TelefoneCelular = mskTelefoneCelular.Text;
                f.IdFuncao = int.Parse(cmbFuncao.SelectedValue.ToString());
                f.Email = txbEmail.Text;
                f.Localidade = l;

                var resultado = funcCont.Insert(f);

                if (resultado == null)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível cadastrar o funcionário!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
