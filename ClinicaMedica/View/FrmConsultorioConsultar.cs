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
            dgvConsultorio.Columns["IdConsultorio"].HeaderText = "Código";
            dgvConsultorio.Columns["NomeFantasia"].HeaderText = "Nome Fatnasia";
            dgvConsultorio.Columns["RazaoSocial"].HeaderText = "Razao Social";
            dgvConsultorio.Columns["CNPJ"].HeaderText = "CNPJ";
            dgvConsultorio.Columns["HorarioAbertura"].HeaderText = "HorarioAbertura";
            dgvConsultorio.Columns["HorarioFechamento"].HeaderText = "HorarioFechamento";
          //  dgvConsultorio.Columns["Telefone"].HeaderText = "Telefone";
        }

        private void CarregarDataGridView(string filtro, string pesquisa)
        {
            dgvConsultorio.DataSource = new ConsultorioController().Select(filtro, pesquisa);
            dgvConsultorio.Columns["IdConsultorio"].HeaderText = "Código";
            dgvConsultorio.Columns["NomeFantasia"].HeaderText = "Nome Fatnasia";
            dgvConsultorio.Columns["RazaoSocial"].HeaderText = "Razao Social";
            dgvConsultorio.Columns["CNPJ"].HeaderText = "CNPJ";
            dgvConsultorio.Columns["HorarioAbertura"].HeaderText = "HorarioAbertura";
            dgvConsultorio.Columns["HorarioFechamento"].HeaderText = "HorarioFechamento";
          //  dgvConsultorio.Columns["Telefone"].HeaderText = "Telefone";
        }

        private void FrmConsultorioConsultar_Activated_1(object sender, EventArgs e)
        {

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
                else if (rdbExame.Checked)
                {
                    CarregarDataGridView("EXAME", txtBusca.Text);
                }

            }
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked)
            {
                txtBusca.ResetText();
                txtBusca.Focus();
                CarregarDataGridView();
            }
        }
    }

}
