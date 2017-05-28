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
    public partial class FrmProdutoCadastrar : Form
    {
        public FrmProdutoCadastrar()
        {
            InitializeComponent();
        }

        private void FrmProdutoCadastrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Produto' table. You can move, or remove it, as needed.
            this.tB_ProdutoTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Produto);
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Funcao' table. You can move, or remove it, as needed.
            this.tB_FuncaoTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Funcao);

        }
    }
}
