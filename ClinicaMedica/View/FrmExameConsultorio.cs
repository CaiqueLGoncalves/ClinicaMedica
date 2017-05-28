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
    public partial class FrmExameConsultorio : Form
    {
        public FrmExameConsultorio()
        {
            InitializeComponent();
        }

        private void FrmExameConsultorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Exame' table. You can move, or remove it, as needed.
            this.tB_ExameTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Exame);
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Consultorio' table. You can move, or remove it, as needed.
            this.tB_ConsultorioTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Consultorio);

        }
    }
}
