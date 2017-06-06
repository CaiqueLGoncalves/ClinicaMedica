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
                var resposta = ws.consultaCEP(mskCep.Text);
                txbEndereco.Text = resposta.end;
                txbBairro.Text = resposta.bairro;
                txbCidade.Text = resposta.cidade;
                txbEstado.Text = resposta.uf;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ConsultorioController consultCont = new ConsultorioController();
            ConsultorioExameController conexCont = new ConsultorioExameController();
            Consultorio c = new Consultorio();
            Localidade l = new Localidade();
            ConsultorioExame ce = new ConsultorioExame();
            //Exame ex = new Model.Exame();
            c.NomeFantasia = txbNomeFantasia.Text;
            c.RazaoSocial = txbRazaoSocial.Text;
            c.CNPJ = mskCnpj.Text;
            c.HorarioAbertura = dtpHorairoAbertura.Value.TimeOfDay;
            c.HorarioFechamento = dtpHorarioFechamento.Value.TimeOfDay;
            l.Endereco = txbEndereco.Text;
            l.Numero = txbNumero.Text;
            l.Complemento = txbComplemento.Text;
            l.CEP = mskCep.Text;
            l.Bairro = txbBairro.Text;
            l.Cidade = txbCidade.Text;
            l.Estado = txbEstado.Text;
            c.Localidade = l;
            consultCont.Insert(c);
            //ce.IdConsultorio = c.IdConsultorio;

            for (int i = 0; i < dtgExame.SelectedRows.Count; i++)
            {
                ce = new ConsultorioExame();
                ce.IdConsultorio = c.IdConsultorio;
                ce.IdExame = int.Parse(dtgExame.SelectedRows[i].Cells["IdExame"].Value.ToString());
                MessageBox.Show(c.IdConsultorio.ToString() + " " + ce.IdExame.ToString());
                  conexCont.Insert(ce);
            }


            //consultCont.Insert(c);
        }

        private void FrmConsultorioCadastrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Exame' table. You can move, or remove it, as needed.
            this.tB_ExameTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Exame);

        }
    }
}
