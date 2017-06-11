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
    public partial class FrmExameAgendar : Form
    {
        private DateTime data;
        private Consultorio consultorio;
        private Exame exame;

        public FrmExameAgendar(DateTime data, int idConsultorio, int idExame)
        {
            InitializeComponent();
            this.data = data;
            consultorio = new ConsultorioController().Select(idConsultorio);
            exame = new ExameController().Select(idExame);
        }

        private void FrmExameAgendar_Load(object sender, EventArgs e)
        {
            txtConsultorio.Text = consultorio.NomeFantasia;
            txtExame.Text = exame.Nome;

            //Paciente
            CarregarDataGridView();

            // Data, Horário (Inicial) e Horário (Final)
            txtData.Text = data.Date.ToShortDateString();
            DateTime dhMin = new DateTime(data.Year, data.Month, data.Day, consultorio.HorarioAbertura.Hours, consultorio.HorarioAbertura.Minutes, consultorio.HorarioAbertura.Seconds);
            DateTime dhMax = new DateTime(data.Year, data.Month, data.Day, consultorio.HorarioFechamento.Hours, consultorio.HorarioFechamento.Minutes, consultorio.HorarioFechamento.Seconds);
            dtpHorarioInicio.MinDate = dhMin;
            dtpHorarioInicio.MaxDate = dhMax;
            dtpHorarioInicio.Value = dhMin;
            dtpHorarioFinal.MinDate = dhMin;
            dtpHorarioFinal.MaxDate = dhMax;
            dtpHorarioFinal.Value = dhMax;



            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Consultorio' table. You can move, or remove it, as needed.
            //this.tB_ConsultorioTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Consultorio);

        }

        private void CarregarDataGridView()
        {
            dgvListaPacientes.DataSource = new PacienteController().Select();
            dgvListaPacientes.Columns["Codigo"].Visible = false;
            dgvListaPacientes.Columns["Nome"].HeaderText = "Paciente";
            dgvListaPacientes.Columns["RG"].Visible = false;
            dgvListaPacientes.Columns["Sexo"].Visible = false;
            dgvListaPacientes.Columns["DataNascimento"].Visible = false;
            dgvListaPacientes.Columns["TelefoneResidencial"].Visible = false;
            dgvListaPacientes.Columns["TelefoneComercial"].Visible = false;
            dgvListaPacientes.Columns["TelefoneCelular"].Visible = false;
            dgvListaPacientes.Columns["Email"].Visible = false;
            dgvListaPacientes.Columns["CEP"].Visible = false;
            dgvListaPacientes.Columns["Endereco"].Visible = false;
            dgvListaPacientes.Columns["Numero"].Visible = false;
            dgvListaPacientes.Columns["Complemento"].Visible = false;
            dgvListaPacientes.Columns["Bairro"].Visible = false;
            dgvListaPacientes.Columns["Cidade"].Visible = false;
            dgvListaPacientes.Columns["Estado"].Visible = false;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                ExameAgendarController exameAgendar = new ExameAgendarController();
                 AgendaExame agendaexame = new AgendaExame();

                agendaexame.IdConsultorio = consultorio.IdConsultorio;
                agendaexame.IdExame = exame.IdExame;
                agendaexame.IdentificacaoPaciente = Convert.ToInt32(dgvListaPacientes.SelectedRows[0].Cells["Codigo"].Value);
                agendaexame.DataHoraInicio = new DateTime(data.Year, data.Month, data.Day, dtpHorarioInicio.Value.Hour, dtpHorarioInicio.Value.Minute, dtpHorarioInicio.Value.Second);
                agendaexame.DataHoraFim = new DateTime(data.Year, data.Month, data.Day, dtpHorarioFinal.Value.Hour, dtpHorarioFinal.Value.Minute, dtpHorarioFinal.Value.Second);
                agendaexame.Comparecimento = (chkComparecimento.Checked ? true : false);
                agendaexame.Anotacoes = txtAnotacoes.Text;


         
                var resultado = exameAgendar.Insert(agendaexame);

                if (resultado == null)
                {
                    MessageBox.Show("Exame agendado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível agendar o exame!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
