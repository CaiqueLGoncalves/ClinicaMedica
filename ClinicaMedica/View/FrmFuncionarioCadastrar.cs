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
            tB_FuncaoTableAdapter.Fill(clinicaMedicaBDDataSet.TB_Funcao);

            if (cmbFuncao.SelectedIndex != 0)
            {
                txbCRM.Clear();
                lblCRM.Enabled = false;
                txbCRM.Enabled = false;
            }
        }

        private void cmbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFuncao.SelectedIndex != 0)
            {
                txbCRM.Clear();
                lblCRM.Enabled = false;
                txbCRM.Enabled = false;
            }
            else
            {
                lblCRM.Enabled = true;
                txbCRM.Enabled = true;
            }
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
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado!");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Localidade l = new Localidade();

            l.CEP = mskCEP.Text;
            l.Endereco = txbEndereco.Text;
            l.Numero = txbNumero.Text;
            l.Complemento = txbComplemento.Text;
            l.Bairro = txbBairro.Text;
            l.Cidade = txbCidade.Text;
            l.Estado = Utilitario.RetornarSiglaEstado(cmbEstado.SelectedIndex);

            if (cmbFuncao.SelectedIndex == 0)
            {
                MedicoController medicoCont = new MedicoController();
                Medico m = new Medico();

                m.Nome = txbNome.Text;
                m.CPF = mskCPF.Text;
                m.RG = txbRG.Text;
                m.DataNascimento = dtpDataNascimento.Value;
                m.Sexo = (rbtMasculino.Checked) ? rbtMasculino.Text : rbtFeminino.Text;
                m.TelefoneResidencial = mskTelefoneResidencial.Text;
                m.TelefoneComercial = mskTelefoneResidencial.Text;
                m.TelefoneCelular = mskTelefoneCelular.Text;
                m.IdFuncao = int.Parse(cmbFuncao.SelectedValue.ToString());
                m.CRM = txbCRM.Text;
                m.Email = txbEmail.Text;
                m.Localidade = l;

                medicoCont.Insert(m);
            }
            else
            {
                FuncionarioController funcCont = new FuncionarioController();
                Funcionario f = new Funcionario();

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
            }

            Controls.Clear();
        }
    }
}
