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
            Localidade l = new Localidade();

            c.NomeFantasia = txbNomeFantasia.Text;
            c.RazaoSocial = txbRazaoSocial.Text;
            c.CNPJ = txbCnpj.Text;
            c.HorarioAbertura = dtpHorairoAbertura.Value.TimeOfDay;
            c.HorarioFechamento = dtpHorarioFechamento.Value.TimeOfDay;
            l.Endereco = txbEndereco.Text;
            l.Numero = txbNumero.Text;
            l.Complemento = txbComplemento.Text;
            l.CEP = txbCep.Text;
            l.Bairro = txbBairro.Text;
            l.Cidade = txbCidade.Text;
            l.Estado = txbEstado.Text;
            c.Localidade = l;
            consultCont.Insert(c);
        }
    }
}
