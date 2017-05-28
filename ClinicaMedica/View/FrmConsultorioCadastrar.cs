using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmConsultorioCadastrar : Form
    {
        public FrmConsultorioCadastrar()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(txbCep.Text);
                txbEndereco.Text = resposta.end;
                txbBairro.Text = resposta.bairro;
                txbCidade.Text = resposta.cidade;
                txbEstado.Text = resposta.uf;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ConsultorioController consultCont = new ConsultorioController();
            Consultorio c = new Consultorio();

            c.NomeFantasia = txbNomeFantasia.Text;
            c.RazaoSocial = txbRazaoSocial.Text;
            c.CNPJ = txbCnpj.Text;
            c.HorarioAbertura = dtpHorairoAbertura.Value.TimeOfDay;
            c.HorarioFechamento = dtpHorarioFechamento.Value.TimeOfDay;
            c.Localidade.Endereco = txbEndereco.Text;
            c.Localidade.Numero = txbNumero.Text;
            c.Localidade.Complemento = txbComplemento.Text;
            c.Localidade.CEP = txbCep.Text;
            c.Localidade.Cidade = txbCidade.Text;
            c.Localidade.Estado = txbEstado.Text;

            consultCont.Insert(c);
        }
    }
}
