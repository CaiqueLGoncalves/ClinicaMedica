using ClinicaMedica.Controller;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmConsultaGerenciar : Form
    {
        public FrmConsultaGerenciar()
        {
            InitializeComponent();
        }

        private void FrmConsultaGerenciar_Load(object sender, EventArgs e)
        {
            TB_ConsultorioTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Consultorio);
            CarregarDataGridView();
        }

        private void FrmConsultaGerenciar_Activated(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }

        private void mclCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            CarregarDataGridView();
        }

        private void cmbConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            FrmConsultaCadastrar consCadastrar = new FrmConsultaCadastrar(mclCalendario.SelectionStart, Convert.ToInt32(cmbConsultorio.SelectedValue));
            consCadastrar.ShowDialog(this);
        }

        private void CarregarDataGridView()
        {
            DateTime dataSelecionada = mclCalendario.SelectionStart;
            int consultorioSelecionado = Convert.ToInt32(cmbConsultorio.SelectedValue);

            dgvConsultas.DataSource = new ConsultaController().Select(dataSelecionada, consultorioSelecionado);
            dgvConsultas.Columns["Codigo"].Visible = false;
            dgvConsultas.Columns["Inicio"].HeaderText = "Início";
            dgvConsultas.Columns["Paciente"].HeaderText = "Nome do Paciente";
            dgvConsultas.Columns["Medico"].HeaderText = "Nome do Médico";
        }
    }
}
