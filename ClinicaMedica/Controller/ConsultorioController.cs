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

                var erros = Validacao.ValidaConsultorio(consultorio);


                if (erros.Count() == 0)
                {
                    try
                    {
                        db.TB_Consultorio.Add(consultorio);
                        db.SaveChanges();
                        MessageBox.Show("Consultório cadastrado com sucesso!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível cadastrar o consultório!\n" + e.Message);
                    }
                  //  CadastroCargo.ActiveForm.Close();

                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }
            
        }
    }
}
