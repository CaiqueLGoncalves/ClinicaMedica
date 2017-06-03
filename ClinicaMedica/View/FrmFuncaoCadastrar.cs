using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncaoCadastrar : Form
    {
        public FrmFuncaoCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FuncaoController funcaoCont = new FuncaoController();
            Funcao f = new Funcao();

            f.Nome = txbNome.Text;
            f.Descricao = txbDescricao.Text;

            funcaoCont.Insert(f);
            Controls.Clear();
        }
    }
}
