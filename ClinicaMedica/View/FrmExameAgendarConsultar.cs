using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Controller;


namespace ClinicaMedica.View
{
    public partial class FrmExameAgendarConsultar : Form
    {
        public FrmExameAgendarConsultar()
        {
            InitializeComponent();
            CarregarDataGridView();
        }

        private void CarregarDataGridView()
        {
            dgvExame.DataSource = new ExameAgendarController().Select();
            dgvExame.Columns["IdAgendaExame"].Visible = false;
            dgvExame.Columns["IdExame"].Visible = false;
            dgvExame.Columns["IdConsultorio"].Visible = false;
            dgvExame.Columns["IdentificacaoPaciente"].Visible = false;
            dgvExame.Columns["Consultorio"].HeaderText = "Consultório";
            dgvExame.Columns["Exame"].HeaderText = "Exame";
            dgvExame.Columns["Paciente"].HeaderText = "Paciente";
            dgvExame.Columns["DataHoraInicio"].HeaderText = "Data Inicio";
            dgvExame.Columns["DataHoraFim"].HeaderText = "Data Fim";
            dgvExame.Columns["Comparecimento"].HeaderText = "Comparecimento";
            dgvExame.Columns["Anotacoes"].HeaderText = "Anotacoes";

        }

        private void CarregarDataGridView(string filtro, string pesquisa)
        {
            dgvExame.DataSource = new ExameAgendarController().Select(filtro,pesquisa);
            dgvExame.Columns["IdAgendaExame"].Visible = false;
            dgvExame.Columns["IdExame"].Visible = false;
            dgvExame.Columns["IdConsultorio"].Visible = false;
            dgvExame.Columns["IdentificacaoPaciente"].Visible = false;
            dgvExame.Columns["Consultorio"].HeaderText = "Consultório";
            dgvExame.Columns["Exame"].HeaderText = "Exame";
            dgvExame.Columns["Paciente"].HeaderText = "Paciente";
            dgvExame.Columns["DataHoraInicio"].HeaderText = "Data Inicio";
            dgvExame.Columns["DataHoraFim"].HeaderText = "Data Fim";
            dgvExame.Columns["Comparecimento"].HeaderText = "Comparecimento";
            dgvExame.Columns["Anotacoes"].HeaderText = "Anotacoes";

        }

        private void FrmExameAgendarConsultar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Exame' table. You can move, or remove it, as needed.
            this.tB_ExameTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Exame);
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Consultorio' table. You can move, or remove it, as needed.
            this.tB_ConsultorioTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Consultorio);

        }

        private void cmbConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDataGridView("CONSULTORIO", cmbConsultorio.Text);
        }

        private void cmbExame_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDataGridView("EXAME", cmbExame.Text);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            cmbConsultorio.Visible = true;
            cmbExame.Visible = false;
            txtBusca.Visible = false;

        }

        private void rdbExame_CheckedChanged(object sender, EventArgs e)
        {
            cmbExame.Visible = true;
            cmbConsultorio.Visible = false;
            txtBusca.Visible = false;

        }

        private void rdbPessoa_CheckedChanged(object sender, EventArgs e)
        {
            txtBusca.Visible = true;
            txtBusca.Focus();
            cmbExame.Visible = false;
            cmbConsultorio.Visible = false;
        }

        private void txtPessoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBusca.Text.Equals(""))
            {
                CarregarDataGridView();
            }
            else
            {
                    CarregarDataGridView("NOME", txtBusca.Text);
            }
        }

        private void dgvExame_DoubleClick(object sender, EventArgs e)
        {
            int idAgendaExame = Convert.ToInt32(dgvExame.SelectedRows[0].Cells["IdAgendaExame"].Value.ToString());
            int identificacaoPaciente = Convert.ToInt32(dgvExame.SelectedRows[0].Cells["IdentificacaoPaciente"].Value.ToString());
            int idExame = Convert.ToInt32(dgvExame.SelectedRows[0].Cells["IdExame"].Value.ToString());
            int idConsultorio = Convert.ToInt32(dgvExame.SelectedRows[0].Cells["IdConsultorio"].Value.ToString());
            DateTime DataHoraInicio = Convert.ToDateTime(dgvExame.SelectedRows[0].Cells["DataHoraInicio"].Value.ToString());
            DateTime DataHoraFim = Convert.ToDateTime(dgvExame.SelectedRows[0].Cells["DataHoraFim"].Value.ToString());
            //DateTime horarioabertura = Convert.ToDateTime(dgvConsultorio.SelectedRows[0].Cells["HorarioAbertura"].Value);
            //DateTime horariofechamento = Convert.ToDateTime(dgvConsultorio.SelectedRows[0].Cells["HorarioFechamento"].Value);
            string consultorio = dgvExame.SelectedRows[0].Cells["Consultorio"].Value.ToString();
            string paciente = dgvExame.SelectedRows[0].Cells["Paciente"].Value.ToString();
            string exame = dgvExame.SelectedRows[0].Cells["Exame"].Value.ToString();
            bool comparecimento = Convert.ToBoolean(dgvExame.SelectedRows[0].Cells["Comparecimento"].Value.ToString());
            string anotacoes = dgvExame.SelectedRows[0].Cells["Anotacoes"].Value.ToString();

            FrmExameAgendarManter exagendar = new FrmExameAgendarManter(idAgendaExame, identificacaoPaciente, idExame, idConsultorio, DataHoraInicio, DataHoraFim, consultorio, paciente, exame, comparecimento, anotacoes);
            exagendar.ShowDialog(this);


        }
    }
}
