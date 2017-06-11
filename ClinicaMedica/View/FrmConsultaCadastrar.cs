using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmConsultaCadastrar : Form
    {
        private DateTime data;
        private Consultorio consultorio;

        public FrmConsultaCadastrar(DateTime data, int idConsultorio)
        {
            InitializeComponent();
            this.data = data;
            consultorio = new ConsultorioController().Select(idConsultorio);
        }

        private void FrmConsultaCadastrar_Load(object sender, EventArgs e)
        {
            // Consultório 
            txbConsultorio.Text = consultorio.NomeFantasia;

            // Médico
            cmbMedico.DataSource = new ConsultorioController().FindMedico(consultorio.IdConsultorio);
            cmbMedico.DisplayMember = "Nome";
            cmbMedico.ValueMember = "Identificacao";

            // Paciente
            CarregarDataGridView();

            // Data, Horário (Inicial) e Horário (Final)
            txbData.Text = data.Date.ToShortDateString();
            DateTime dhMin = new DateTime(data.Year, data.Month, data.Day, consultorio.HorarioAbertura.Hours, consultorio.HorarioAbertura.Minutes, consultorio.HorarioAbertura.Seconds);
            DateTime dhMax = new DateTime(data.Year, data.Month, data.Day, consultorio.HorarioFechamento.Hours, consultorio.HorarioFechamento.Minutes, consultorio.HorarioFechamento.Seconds);
            dtpHorarioInicio.MinDate = dhMin;
            dtpHorarioInicio.MaxDate = dhMax;
            dtpHorarioInicio.Value = dhMin;
            dtpHorarioFinal.MinDate = dhMin;
            dtpHorarioFinal.MaxDate = dhMax;
            dtpHorarioFinal.Value = dhMax;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaController consultaCont = new ConsultaController();
                Consulta consulta = new Consulta();

                consulta.IdConsultorio = consultorio.IdConsultorio;
                consulta.IdentificacaoMedico = Convert.ToInt32(cmbMedico.SelectedValue);
                consulta.IdentificacaoPaciente = Convert.ToInt32(dgvListaPacientes.SelectedRows[0].Cells["Codigo"].Value);
                consulta.DataHoraInicio = new DateTime(data.Year, data.Month, data.Day, dtpHorarioInicio.Value.Hour, dtpHorarioInicio.Value.Minute, dtpHorarioInicio.Value.Second);
                consulta.DataHoraFim = new DateTime(data.Year, data.Month, data.Day, dtpHorarioFinal.Value.Hour, dtpHorarioFinal.Value.Minute, dtpHorarioFinal.Value.Second);
                consulta.Comparecimento = (chkComparecimento.Checked ? true : false);
                consulta.Anotacoes = txbAnotacoes.Text;

                var resultado = consultaCont.Insert(consulta);

                if (resultado == null)
                {
                    MessageBox.Show("Consulta agendada com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível agendar a paciente!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
