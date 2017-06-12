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
    public partial class FrmExameGerencia : Form
    {
        public FrmExameGerencia()
        {
            InitializeComponent();
        }

        private void FrmExameGerencia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Exame' table. You can move, or remove it, as needed.
            this.tB_ExameTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Exame);
            //CarregarDataGridViewZero();
            cmbExame.SelectedIndex = -1;

        }

        private void cmbExame_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbConsultorio.Enabled = true;

            var consultorios = new ConsultorioController().Select("EXAME", cmbExame.Text);
            bool isEmpty = !consultorios.Any();
            if (isEmpty)
            {
                cmbConsultorio.DataSource = null;
                cmbConsultorio.Enabled = false;
                MessageBox.Show("Não existem Consultórios cadastrados com este exame", "Clínica Médica");
                btnNovo.Enabled = false;
            }
            else
            {
                bindingSource1.DataSource = consultorios;//new ConsultorioController().Select("EXAME", cmbExame.Text);
                cmbConsultorio.DataSource = bindingSource1.DataSource;
                cmbConsultorio.DisplayMember = "NomeFantasia";
                cmbConsultorio.ValueMember = "IdConsultorio";
                btnNovo.Enabled = true;
                cmbConsultorio.SelectedIndex = -1;
                cmbConsultorio.Enabled = true;
                CarregarDataGridView();
            }


        }

        private void CarregarDataGridView()
        {
            DateTime dataSelecionada = mntCalendario.SelectionStart;
            int consultorioSelecionado = Convert.ToInt32(cmbConsultorio.SelectedValue);
            int exameSelecionado = Convert.ToInt32(cmbExame.SelectedValue);
            dtgHorarios.DataSource = new ExameAgendarController().Select(dataSelecionada, consultorioSelecionado, exameSelecionado);
            dtgHorarios.Columns["IdAgendaExame"].Visible = false;
            dtgHorarios.Columns["IdExame"].Visible = false;
            dtgHorarios.Columns["IdConsultorio"].Visible = false;
            dtgHorarios.Columns["IdentificacaoPaciente"].Visible = false;
            dtgHorarios.Columns["Consultorio"].HeaderText = "Consultorio";
            dtgHorarios.Columns["Paciente"].HeaderText = "Paciente";
            dtgHorarios.Columns["Exame"].HeaderText = "Exame";
            dtgHorarios.Columns["DataHoraInicio"].HeaderText = "Data Inicio";
            dtgHorarios.Columns["DataHoraFim"].HeaderText = "Data Fim";
            dtgHorarios.Columns["Comparecimento"].HeaderText = "Comparecimento";
            dtgHorarios.Columns["Anotacoes"].HeaderText = "Anotacoes";
        }

        private void CarregarDataGridViewZero()
        {
            dtgHorarios.DataSource = new ExameAgendarController().Select();
            dtgHorarios.Columns["IdAgendaExame"].Visible = false;
            dtgHorarios.Columns["IdExame"].Visible = false;
            dtgHorarios.Columns["IdConsultorio"].Visible = false;
            dtgHorarios.Columns["IdentificacaoPaciente"].Visible = false;
            dtgHorarios.Columns["Consultorio"].HeaderText = "Consultorio";
            dtgHorarios.Columns["Paciente"].HeaderText = "Paciente";
            dtgHorarios.Columns["Exame"].HeaderText = "Exame";
            dtgHorarios.Columns["DataHoraInicio"].HeaderText = "Data Inicio";
            dtgHorarios.Columns["DataHoraFim"].HeaderText = "Data Fim";
            dtgHorarios.Columns["Comparecimento"].HeaderText = "Comparecimento";
            dtgHorarios.Columns["Anotacoes"].HeaderText = "Anotacoes";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmExameAgendar exameAgendar = new FrmExameAgendar(mntCalendario.SelectionStart, Convert.ToInt32(cmbConsultorio.SelectedValue), Convert.ToInt32(cmbExame.SelectedValue));
            exameAgendar.ShowDialog(this);
        }

        private void FrmExameGerencia_Activated(object sender, EventArgs e)
        {
            CarregarDataGridViewZero();
        }

        private void chkExame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExame.Checked) CarregarDataGridViewZero();
            else dtgHorarios.DataSource = null; 
        }

        private void cmbConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConsultorio.SelectedIndex != -1)
            {
              //  CarregarDataGridView();
            }

        }

        private void mntCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            CarregarDataGridView();
        }
    }
}
