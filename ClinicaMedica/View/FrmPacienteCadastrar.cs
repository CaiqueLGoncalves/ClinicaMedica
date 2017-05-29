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
                txbEstado.Text = resposta.uf;
                txbEstado.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado!");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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
            l.Estado = txbEstado.Text;

            p.Nome = txbNome.Text;
            p.CPF = mskCPF.Text;
            p.RG = txbRG.Text;
            p.DataNascimento = dtpDataNascimento.Value;
            p.Email = txbEmail.Text;
            p.Localidade = l;

            pacienteCont.Insert(p);
            Controls.Clear();
        }
    }
}