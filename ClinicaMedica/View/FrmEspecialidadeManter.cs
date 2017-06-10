using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmEspecialidadeManter : Form
    {
        private int idEspecialidade;

        public FrmEspecialidadeManter(int idEspecialidade, string nome, string descricao)
        {
            InitializeComponent();
            this.idEspecialidade = idEspecialidade;
            txbNome.Text = nome;
            txbDescricao.Text = descricao;
        }
    }
}
