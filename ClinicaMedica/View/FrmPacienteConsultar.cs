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
    public partial class FrmPacienteConsultar : Form
    {
        public FrmPacienteConsultar()
        {
            InitializeComponent();
        }

        private void FrmPacienteConsultar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clinicaMedicaBDDataSet.TB_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_UsuarioTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Usuario);
            // TODO: esta linha de código carrega dados na tabela 'clinicaMedicaBDDataSet.TB_Usuario_Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_Usuario_PacienteTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Usuario_Paciente);

        }
    }
}
