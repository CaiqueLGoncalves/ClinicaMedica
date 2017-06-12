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
    public partial class FrmExameCadastrar : Form
    {
        public FrmExameCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Exame ex = new Exame();
            ExameController exc = new ExameController();

            ex.Nome = txbNome.Text;
            ex.Recomendacoes = txbRecomendacoes.Text;
            try
            {
                exc.Insert(ex);
                Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao inserir.", "Clínica Médica");
            }
        }
    }
}
