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
            EspecialidadeController espCont = new EspecialidadeController();
            Especialidade esp = new Especialidade();

            esp.Nome = txbNome.Text;
            esp.Descricao = txbDescricao.Text;

            espCont.Insert(esp);
            Controls.Clear();
        }
    }
}
