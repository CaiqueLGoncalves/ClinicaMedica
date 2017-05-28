using ClinicaMedica.Model;
using ClinicaMedica.Controller;
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
    public partial class FrmEstoqueCadastrar : Form
    {
        public FrmEstoqueCadastrar()
        {
            InitializeComponent();
        }

        private void FrmEstoqueCadastrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Consultorio' table. You can move, or remove it, as needed.
            this.tB_ConsultorioTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Consultorio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            EstoqueController estcont = new EstoqueController();
            estoque.IdConsultorio = Int32.Parse(cmbConsultorio.SelectedValue.ToString());
            estoque.Nome = txbDescricao.Text;
            if (cmbRefrigeracao.SelectedIndex == 0) estoque.Refrigeracao = false;
            else estoque.Refrigeracao = true;

            estcont.Insert(estoque);
        }
    }
}
