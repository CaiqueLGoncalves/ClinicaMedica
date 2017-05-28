using ClinicaMedica.Controller;
using ClinicaMedica.Model;
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
            cmbTipo.DataSource = Enum.GetValues(typeof(ProductType));
        }

        private void FrmProdutoCadastrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Produto' table. You can move, or remove it, as needed.
           // this.tB_ProdutoTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Produto);
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Produto' table. You can move, or remove it, as needed.
           // this.tB_ProdutoTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Produto);
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Funcao' table. You can move, or remove it, as needed.
          //  this.tB_FuncaoTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Funcao);
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            ProdutoController pc = new ProdutoController();

            p.Nome = txbNome.Text;
            p.Descricao = txbDescricao.Text;
            p.Tipo = (ProductType) Enum.Parse(typeof(ProductType),cmbTipo.SelectedItem.ToString());
            pc.Insert(p);
        }
    }
}
