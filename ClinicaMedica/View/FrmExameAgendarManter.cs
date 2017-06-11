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
    public partial class FrmExameAgendarManter : Form
    {
        private int idAgendaExame;
        private int idPaciente;
        private int idExame;
        private int idConsultorio;
        private DateTime data;
        private Consultorio consultoriobj;
        public FrmExameAgendarManter(int idAgendaExame, int identificacaoPaciente, int idExame, int idConsultorio, DateTime DataHoraInicio, DateTime DataHoraFim, string consultorio, string paciente, string exame, bool comparecimento, string anotacoes)
        {
            InitializeComponent();
            this.idAgendaExame = idAgendaExame;
            this.idPaciente = identificacaoPaciente;
            this.idExame = idExame;
            this.idConsultorio = idConsultorio;
            txtConsultorio.Text = consultorio;
            txtExame.Text = exame;
            txtPaciente.Text = paciente;
            mntData.SelectionStart = DataHoraInicio;
            this.data = mntData.SelectionStart;
            dtpHorarioInicio.Value = DataHoraInicio;
            dtpHorarioFinal.Value = DataHoraFim;
            if (comparecimento) chkComparecimento.Checked = true;
            else chkComparecimento.Checked = false;
            txtAnotacoes.Text = anotacoes;
            consultoriobj = new ConsultorioController().Select(idConsultorio);


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ExameAgendarController exameCont = new ExameAgendarController();
                AgendaExame aex = new AgendaExame();

                aex.IdAgendaExame = idAgendaExame;
                aex.IdentificacaoPaciente = idPaciente;
                aex.IdExame = idExame;
                aex.IdConsultorio = idConsultorio;
                aex.DataHoraFim = new DateTime(mntData.SelectionStart.Year, mntData.SelectionStart.Month, mntData.SelectionStart.Day, dtpHorarioFinal.Value.Hour, dtpHorarioFinal.Value.Minute, dtpHorarioFinal.Value.Second); 
                aex.DataHoraInicio = new DateTime(dtpHorarioInicio.Value.Year, mntData.SelectionStart.Month, mntData.SelectionStart.Day, dtpHorarioInicio.Value.Hour, dtpHorarioInicio.Value.Minute, dtpHorarioInicio.Value.Second); 
                if (chkComparecimento.Checked) aex.Comparecimento = true;
                else aex.Comparecimento = false;
                aex.Anotacoes = txtAnotacoes.Text; 



                var resultado = exameCont.Update(aex);

                if (resultado == null)
                {
                    MessageBox.Show("Agendamento de exame alterado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível alterar o agendamento de exame!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ExameAgendarController exCont = new ExameAgendarController();
                AgendaExame exame = new AgendaExame();
                exame.IdAgendaExame = idAgendaExame;

                if (exCont.Delete(exame))
                {
                    MessageBox.Show("Agendamento de Exame excluído com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmExameAgendarManter_Load(object sender, EventArgs e)
        {

        }
    }
}
