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
    public partial class FrmConsultorioManter : Form
    {
        private int codigo;
        public FrmConsultorioManter(int codigo, string nomefantasia, string razaosocial, string cnpj, TimeSpan horarioabertura, TimeSpan horariofechamento, string telefone, string cep, string endereco, string numero, string complemento, string bairro, string cidade, string estado)
        {
            InitializeComponent();

            this.codigo = codigo;
            txbNomeFantasia.Text = nomefantasia;
            txbRazaoSocial.Text = razaosocial;
            mskCnpj.Text = cnpj;
            dtpHorairoAbertura.Value = DateTime.Now.Add(horarioabertura);
            dtpHorarioFechamento.Value = DateTime.Now.Add(horariofechamento);
            mskTelefone.Text = telefone;
            mskCep.Text = cep;
            txbEndereco.Text = endereco;
            txbNumero.Text = numero;
            txbComplemento.Text = complemento;
            txbBairro.Text = bairro;
            txbCidade.Text = cidade;
            txbEstado.Text = estado;

        }

        private void FrmConsultorioManter_Load(object sender, EventArgs e)
        {
            this.tB_ExameTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Exame);

            //tB_ExameTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Consultorio);
            // Deseleciona todas as especialidades
            for (int i = 0; i < dtgExame.Rows.Count; i++)
            {
                dtgExame.Rows[i].Selected = false;
            }

            // Seleciona apenas as especialidades atribuídas ao médico
            var exames = new ConsultorioExameController().Select(codigo);

            foreach (int ex in exames)
            {
                for (int i = 0; i < dtgExame.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtgExame.Rows[i].Cells["IdExame"].Value.ToString()) == ex)
                    {
                        dtgExame.Rows[i].Selected = true;
                    }
                }
            }
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
                txbEndereco.Enabled = false;
                txbBairro.Enabled = false;
                txbCidade.Enabled = false;
                txbEstado.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado");
                txbEndereco.Enabled = true;
                txbBairro.Enabled = true;
                txbCidade.Enabled = true;
                txbEstado.Enabled = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultorioController concon = new ConsultorioController();
                Consultorio c = new Consultorio();
                Localidade l = new Localidade();

                List<int> listaIdExame = new List<int>();

                for (int i = 0; i < dtgExame.SelectedRows.Count; i++)
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
                    ConsultorioExameController conexCont = new ConsultorioExameController();

                    foreach (var IdEx in listaIdExame)
                    {
                        ConsultorioExame ce = new ConsultorioExame();
                        ce.IdConsultorio = c.IdConsultorio;
                        ce.IdExame = IdEx;
                        conexCont.Insert(ce);
                        //numeroErros += meCont.Insert(me);
                    }


                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.ToString());
                }


                var resultado = concon.Update(c);

                if (resultado == null)
                {
                    MessageBox.Show("Consultório alterado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível alterar o consultório!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txbEndereco.Enabled = true;
            txbBairro.Enabled = true;
            txbCidade.Enabled = true;
            txbEstado.Enabled = true;
        }
    }
}
