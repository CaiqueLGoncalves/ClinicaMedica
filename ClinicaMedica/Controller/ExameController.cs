using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.Controller
{
    class ExameController
    {
        DataModelContainer db = new DataModelContainer();

        public void Insert(Exame exame)
        {
            var erros = Validacao.ValidaExame(exame);

            if (erros.Count() == 0)
            {
                try
                {
                    db.TB_Exame.Add(exame);
                    db.SaveChanges();
                    MessageBox.Show("Exame cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não foi possível cadastrar o exame!\n" + e.Message);
                }
            }
            else
            {
                foreach (var e in erros)
                    MessageBox.Show(e.ToString());
            }
        }

    }
}
