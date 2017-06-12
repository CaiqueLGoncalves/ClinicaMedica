using ClinicaMedica.Controller;
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
    public partial class FrmConsultorioConsultar : Form
    {
        public FrmConsultorioConsultar()
        {
            InitializeComponent();
        }



        private void FrmConsultorioConsultarcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Exame' table. You can move, or remove it, as needed.
            this.tB_ExameTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Exame);
            CarregarDataGridView();
            txtBusca.Focus();
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Consultorio' table. You can move, or remove it, as needed.
            //  this.tB_ConsultorioTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Consultorio);
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.ConsultorioExame' table. You can move, or remove it, as needed.
            //  this.consultorioExameTableAdapter.Fill(this.clinicaMedicaBDDataSet.ConsultorioExame);
        }
        private void FrmConsultorioConsultar_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
            txtBusca.Focus();
        }

        private void FrmConsultorioConsultar_Activated(object sender, EventArgs e)
        {
            CarregarDataGridView();
            txtBusca.Focus();
        }



        private void CarregarDataGridView()
        {
            dgvConsultorio.DataSource = new ConsultorioController().Select();
            //dgvConsultorio.Columns["IdConsultorio"].HeaderText = "Código";
            dgvConsultorio.Columns["IdConsultorio"].Visible = false;
            dgvConsultorio.Columns["NomeFantasia"].HeaderText = "Nome Fantasia";
            dgvConsultorio.Columns["RazaoSocial"].HeaderText = "Razao Social";
            dgvConsultorio.Columns["CNPJ"].HeaderText = "CNPJ";
            dgvConsultorio.Columns["HorarioAbertura"].HeaderText = "HorarioAbertura";
            dgvConsultorio.Columns["HorarioFechamento"].HeaderText = "HorarioFechamento";
            dgvConsultorio.Columns["Telefone"].HeaderText = "Telefone";
            dgvConsultorio.Columns["CEP"].HeaderText = "CEP";
            dgvConsultorio.Columns["Endereco"].HeaderText = "Endereço";
            dgvConsultorio.Columns["Numero"].HeaderText = "Numero";
            dgvConsultorio.Columns["Complemento"].HeaderText = "Complemento";
            dgvConsultorio.Columns["Bairro"].HeaderText = "Bairro";
            dgvConsultorio.Columns["Cidade"].HeaderText = "Cidade";
            dgvConsultorio.Columns["Estado"].HeaderText = "Estado";
        }

        private void CarregarDataGridView(string filtro, string pesquisa)
        {
            dgvConsultorio.DataSource = new ConsultorioController().Select(filtro, pesquisa);
            //dgvConsultorio.Columns["IdConsultorio"].HeaderText = "Código";
            dgvConsultorio.Columns["IdConsultorio"].Visible = false;
            dgvConsultorio.Columns["NomeFantasia"].HeaderText = "Nome Fantasia";
            dgvConsultorio.Columns["RazaoSocial"].HeaderText = "Razao Social";
            dgvConsultorio.Columns["CNPJ"].HeaderText = "CNPJ";
            dgvConsultorio.Columns["HorarioAbertura"].HeaderText = "HorarioAbertura";
            dgvConsultorio.Columns["HorarioFechamento"].HeaderText = "HorarioFechamento";
            dgvConsultorio.Columns["Telefone"].HeaderText = "Telefone";
            dgvConsultorio.Columns["CEP"].HeaderText = "CEP";
            dgvConsultorio.Columns["Endereco"].HeaderText = "Endereço";
            dgvConsultorio.Columns["Numero"].HeaderText = "Numero";
            dgvConsultorio.Columns["Complemento"].HeaderText = "Complemento";
            dgvConsultorio.Columns["Bairro"].HeaderText = "Bairro";
            dgvConsultorio.Columns["Cidade"].HeaderText = "Cidade";
            dgvConsultorio.Columns["Estado"].HeaderText = "Estado";
         }

        private void FrmConsultorioConsultar_Activated_1(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }

        private void txtBusca_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBusca.Text.Equals(""))
            {
                CarregarDataGridView();
            }
            else
            {
                if (rdbNome.Checked)
                {
                    CarregarDataGridView("NOME", txtBusca.Text);
                }
                else if (rdbCidade.Checked)
                {
                    CarregarDataGridView("CIDADE", txtBusca.Text);
                }

            }
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked)
            {
                txtBusca.Visible = true;
                cmbExame.Visible = false;
                txtBusca.ResetText();
                txtBusca.Focus();
                CarregarDataGridView();
            }
        }

        private void cmbExame_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDataGridView("EXAME", cmbExame.Text);

        }

        private void rdbCidade_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCidade.Checked)
            {
                txtBusca.Visible = true;
                cmbExame.Visible = false;
                txtBusca.ResetText();
                txtBusca.Focus();
                CarregarDataGridView();
            }
        }

        private void dgvConsultorio_DoubleClick(object sender, EventArgs e)
        {

            int idconsultorio = Convert.ToInt32(dgvConsultorio.SelectedRows[0].Cells["IdConsultorio"].Value.ToString());
            string nomefantasia = dgvConsultorio.SelectedRows[0].Cells["NomeFantasia"].Value.ToString();
            string razaosocial = dgvConsultorio.SelectedRows[0].Cells["RazaoSocial"].Value.ToString();
            string cnpj = dgvConsultorio.SelectedRows[0].Cells["CNPJ"].Value.ToString();
            TimeSpan horarioabertura = TimeSpan.Parse(dgvConsultorio.SelectedRows[0].Cells["HorarioAbertura"].Value.ToString());
            TimeSpan horariofechamento = TimeSpan.Parse(dgvConsultorio.SelectedRows[0].Cells["HorarioFechamento"].Value.ToString());
            //DateTime horarioabertura = Convert.ToDateTime(dgvConsultorio.SelectedRows[0].Cells["HorarioAbertura"].Value);
            //DateTime horariofechamento = Convert.ToDateTime(dgvConsultorio.SelectedRows[0].Cells["HorarioFechamento"].Value);
            string telefone = dgvConsultorio.SelectedRows[0].Cells["Telefone"].Value.ToString();
            string cep = dgvConsultorio.SelectedRows[0].Cells["CEP"].Value.ToString();
            string endereco = dgvConsultorio.SelectedRows[0].Cells["Endereco"].Value.ToString();
            string numero = dgvConsultorio.SelectedRows[0].Cells["Numero"].Value.ToString();
            string complemento = dgvConsultorio.SelectedRows[0].Cells["Complemento"].Value.ToString();
            string bairro = dgvConsultorio.SelectedRows[0].Cells["Bairro"].Value.ToString();
            string cidade = dgvConsultorio.SelectedRows[0].Cells["Cidade"].Value.ToString();
            string estado = dgvConsultorio.SelectedRows[0].Cells["Estado"].Value.ToString();


            FrmConsultorioManter consMant = new FrmConsultorioManter(idconsultorio, nomefantasia, razaosocial, cnpj, horarioabertura, horariofechamento, telefone, cep, endereco, numero, complemento, bairro, cidade, estado);
            consMant.ShowDialog(this);

        }

        private void dgvConsultorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbExame_CheckedChanged(object sender, EventArgs e)
        {
            cmbExame.SelectedIndex = -1;
            txtBusca.Visible = false;
            cmbExame.Visible = true;
        }

        private void rdbTudo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDataGridView();
            txtBusca.Visible = false;
            cmbExame.Visible = false;
        }
    }

}
