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
    }
}
