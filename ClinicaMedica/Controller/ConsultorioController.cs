using ClinicaMedica.Model;
using ClinicaMedica.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.Controller
{
    class ConsultorioController
    {
        private DataModelContainer db = new DataModelContainer();

        public void Insert(Consultorio consultorio)
        {
            try
            {
                db.TB_Consultorio.Add(consultorio);
                db.SaveChanges();
                MessageBox.Show("Consultório Cadastrado com sucesso!!!");
            }
            catch (Exception e)
            {
                MessageBox.Show("não foi possível cadastrar o consultório!\n" + e.Message);
            }
           
        }
    }
}
