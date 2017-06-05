using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmEspecialidadeCadastrar : Form
    {
        public FrmEspecialidadeCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                EspecialidadeController espCont = new EspecialidadeController();
                Especialidade esp = new Especialidade();

                esp.Nome = txbNome.Text;
                esp.Descricao = txbDescricao.Text;

                var resultado = espCont.Insert(esp);

                if (resultado == null)
                {
                    MessageBox.Show("Especialidade cadastrada com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível cadastrar a especialidade!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
