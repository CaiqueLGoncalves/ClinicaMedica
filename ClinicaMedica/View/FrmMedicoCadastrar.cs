using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmMedicoCadastrar : Form
    {
        public FrmMedicoCadastrar()
        {
            InitializeComponent();
        }

        private void FrmMedicoCadastrar_Activated(object sender, EventArgs e)
        {
            TB_EspecialidadeTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Especialidade);
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
            MedicoController medicoCont = new MedicoController();
            Medico m = new Medico();
            Localidade l = new Localidade();

            l.CEP = mskCEP.Text;
            l.Endereco = txbEndereco.Text;
            l.Numero = txbNumero.Text;
            l.Complemento = txbComplemento.Text;
            l.Bairro = txbBairro.Text;
            l.Cidade = txbCidade.Text;
            l.Estado = Utilitario.RetornarSiglaEstado(cmbEstado.SelectedIndex);

            m.Nome = txbNome.Text;
            m.CPF = mskCPF.Text;
            m.RG = txbRG.Text;
            m.DataNascimento = dtpDataNascimento.Value;
            m.Sexo = (rbtMasculino.Checked) ? rbtMasculino.Text : rbtFeminino.Text;

            m.IdFuncao = 1;
            m.CRM = txbCRM.Text;
            // Descobrir como colocar as especialidades escolhidas em m.Especialidade

            m.TelefoneResidencial = mskTelefoneResidencial.Text;
            m.TelefoneComercial = mskTelefoneResidencial.Text;
            m.TelefoneCelular = mskTelefoneCelular.Text;
            m.Email = txbEmail.Text;

            m.Localidade = l;

            medicoCont.Insert(m);

            Controls.Clear();
        }
    }
}
