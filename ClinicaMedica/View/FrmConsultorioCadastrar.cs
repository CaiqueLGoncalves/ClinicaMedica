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
                txbNumero.Enabled = true;
                txbComplemento.Enabled = true;
                txbNumero.Focus();

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado");

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ConsultorioController consultCont = new ConsultorioController();
            Consultorio c = new Consultorio();
            Localidade l = new Localidade();
            // ConsultorioExame ce = new ConsultorioExame();
            //Exame ex = new Model.Exame();
            List<int> listaIdExame = new List<int>();

            for (int i=0; i<dtgExame.SelectedRows.Count; i++)
            {
                listaIdExame.Add(int.Parse(dtgExame.SelectedRows[i].Cells["IdExame"].Value.ToString()));
            }
            listaIdExame.Sort();

            c.NomeFantasia = txbNomeFantasia.Text;
            c.RazaoSocial = txbRazaoSocial.Text;
            c.CNPJ = mskCnpj.Text;
            c.HorarioAbertura = dtpHorairoAbertura.Value.TimeOfDay;
            c.HorarioFechamento = dtpHorarioFechamento.Value.TimeOfDay;
            c.Telefone = mskTelefone.Text;
            l.Endereco = txbEndereco.Text;
            l.Numero = txbNumero.Text;
            l.Complemento = txbComplemento.Text;
            l.CEP = mskCep.Text;
            l.Bairro = txbBairro.Text;
            l.Cidade = txbCidade.Text;
            l.Estado = txbEstado.Text;
            c.Localidade = l;

            try
            {
                //consultCont.Insert(c);
                ConsultorioExameController conexCont = new ConsultorioExameController();
                if (consultCont.Insert(c) == 0)
                {
                    foreach (var IdEx in listaIdExame)
                    {
                        ConsultorioExame ce = new ConsultorioExame();
                        ce.IdConsultorio = c.IdConsultorio;
                        ce.IdExame = IdEx;
                        conexCont.Insert(ce);
                        //numeroErros += meCont.Insert(me);

                    }
                    Close();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }


            //consultCont.Insert(c);
        }

        private void FrmConsultorioCadastrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Exame' table. You can move, or remove it, as needed.
            this.tB_ExameTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Exame);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCEP.Checked)
            {
                txbEndereco.Enabled = true;
                txbNumero.Enabled = true;
                txbComplemento.Enabled = true;
                txbBairro.Enabled = true;
                txbCidade.Enabled = true;
                txbEstado.Enabled = true;
            }
            else
            {
                txbEndereco.Enabled = false;
                txbNumero.Enabled = false;
                txbComplemento.Enabled = false;
                txbBairro.Enabled = false;
                txbCidade.Enabled = false;
                txbEstado.Enabled = false;
            }

        }
    }
}
