using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClinicaMedica.Controller
{
    class EstoqueController
    {
        DataModelContainer db = new DataModelContainer();

        public void Insert(Estoque estoque)
        {
            var erros = Validacao.ValidaEstoque(estoque);

            if (erros.Count()==0)
            {
                try
                {
                    db.TB_Estoque.Add(estoque);
                    db.SaveChanges();
                    MessageBox.Show("Estoque cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não foi possível cadastrar o estoque!\n" + e.Message);
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
