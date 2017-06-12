using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmConsultaManter : Form
    {
        private Consulta consultaAtual;

        public FrmConsultaManter(int codigo)
        {
            InitializeComponent();
            consultaAtual = new ConsultaController().Select(codigo);
        }

        private void FrmConsultaManter_Load(object sender, System.EventArgs e)
        {
            // Consultório
            txbConsultorio.Text = consultaAtual.Consultorio.NomeFantasia;

            // Médico
            cmbMedico.DataSource = new ConsultorioController().FindMedico(consultaAtual.Consultorio.IdConsultorio);
            cmbMedico.DisplayMember = "Nome";
            cmbMedico.ValueMember = "Identificacao";

            cmbMedico.SelectedValue = consultaAtual.IdentificacaoMedico;

            // Paciente
            CarregarDataGridView();

            for (int i = 0; i < dgvListaPacientes.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvListaPacientes.Rows[i].Cells["Codigo"].Value.ToString()) == consultaAtual.IdentificacaoPaciente)
                {
                    dgvListaPacientes.Rows[i].Selected = true;
                }
            }

            // Data
            txbData.Text = consultaAtual.DataHoraInicio.Date.ToShortDateString();

            // Horário (Inicial)
            dtpHorarioInicio.Value = consultaAtual.DataHoraInicio;

            // Horário (Final)
            dtpHorarioFinal.Value = consultaAtual.DataHoraFim;

            // Comparecimento
            if (consultaAtual.Comparecimento)
            {
                chkComparecimento.Checked = true;
            }

            // Anotações
            txbAnotacoes.Text = consultaAtual.Anotacoes;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpHorarioInicio.Value.TimeOfDay.CompareTo(dtpHorarioFinal.Value.TimeOfDay) >= 0)
                {
                    throw new Exception("Horário Inválido! O horário final deve ser maior do que o horário inicial.");
                }

                ConsultaController consultaCont = new ConsultaController();
                Consulta consultaModificada = new Consulta();

                int consulta = consultaAtual.IdConsulta;
                int consultorio = consultaAtual.IdConsultorio;
                DateTime data = consultaAtual.DataHoraInicio;

                consultaModificada.IdConsulta = consulta;
                consultaModificada.IdConsultorio = consultorio;
                consultaModificada.IdentificacaoMedico = Convert.ToInt32(cmbMedico.SelectedValue);
                consultaModificada.IdentificacaoPaciente = Convert.ToInt32(dgvListaPacientes.SelectedRows[0].Cells["Codigo"].Value);
                consultaModificada.DataHoraInicio = new DateTime(data.Year, data.Month, data.Day, dtpHorarioInicio.Value.Hour, dtpHorarioInicio.Value.Minute, dtpHorarioInicio.Value.Second);
                consultaModificada.DataHoraFim = new DateTime(data.Year, data.Month, data.Day, dtpHorarioFinal.Value.Hour, dtpHorarioFinal.Value.Minute, dtpHorarioFinal.Value.Second);
                consultaModificada.Comparecimento = (chkComparecimento.Checked ? true : false);
                consultaModificada.Anotacoes = txbAnotacoes.Text;

                var resultado = consultaCont.Update(consultaModificada);

                if (resultado == null)
                {
                    MessageBox.Show("Consulta alterada com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível alterar a consulta!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaController consCont = new ConsultaController();
                Consulta consulta = new Consulta();
                consulta.IdConsulta = consultaAtual.IdConsulta;

                if (consCont.Delete(consulta))
                {
                    MessageBox.Show("Consulta desmarcada com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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