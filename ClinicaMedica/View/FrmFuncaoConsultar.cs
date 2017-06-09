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
    public partial class FrmFuncaoConsultar : Form
    {
        public FrmFuncaoConsultar()
        {
            InitializeComponent();
        }

        private void FrmFuncaoConsultar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clinicaMedicaBDDataSet.TB_Funcao'. Você pode movê-la ou removê-la conforme necessário.
            this.TB_FuncaoTableAdapter.Fill(this.ClinicaMedicaBDDataSet.TB_Funcao);

        }
    }
}
