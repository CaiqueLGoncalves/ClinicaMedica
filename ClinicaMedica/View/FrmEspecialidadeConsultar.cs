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
    public partial class FrmEspecialidadeConsultar : Form
    {
        public FrmEspecialidadeConsultar()
        {
            InitializeComponent();
        }

        private void FrmEspecialidadeConsultar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clinicaMedicaBDDataSet.TB_Especialidade'. Você pode movê-la ou removê-la conforme necessário.
            TB_EspecialidadeTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Especialidade);
        }
    }
}
