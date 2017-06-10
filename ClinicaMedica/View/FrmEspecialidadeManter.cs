using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmEspecialidadeManter : Form
    {
        private int idEspecialidade;

        public FrmEspecialidadeManter(int idEspecialidade, string nome, string descricao)
        {
            InitializeComponent();

            // ID da Especialidade
            this.idEspecialidade = idEspecialidade;

            // Nome da Especialidade
            txbNome.Text = nome;

            // Descrição da Especialidade
            txbDescricao.Text = descricao;
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            try
            {
                EspecialidadeController espCont = new EspecialidadeController();
                Especialidade especialidade = new Especialidade();
                especialidade.IdEspecialidade = idEspecialidade;

                if (espCont.Delete(especialidade))
                {
                    MessageBox.Show("Especialidade excluída com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}