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
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado!");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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

            funcCont.Insert(f);

            Controls.Clear();
        }
    }
}
