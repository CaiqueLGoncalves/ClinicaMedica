﻿using System;
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
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void consultórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultorioCadastrar consultorio = new FrmConsultorioCadastrar();
            consultorio.Show();
        }
    }
}
