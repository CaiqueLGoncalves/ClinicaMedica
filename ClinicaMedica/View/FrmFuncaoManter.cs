using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncaoManter : Form
    {
        private int idFuncao;

        public FrmFuncaoManter(int idFuncao, string nome, string descricao)
        {
            InitializeComponent();
            this.idFuncao = idFuncao;
            txbNome.Text = nome;
            txbDescricao.Text = descricao;
        }
    }
}
