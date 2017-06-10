using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncaoManter : Form
    {
        private int idFuncao;

        public FrmFuncaoManter(int idFuncao, string nome, string descricao)
        {
            InitializeComponent();

            // ID da Função
            this.idFuncao = idFuncao;

            // Nome da Função
            txbNome.Text = nome;

            // Descrição da Função
            txbDescricao.Text = descricao;
        }
    }
}
