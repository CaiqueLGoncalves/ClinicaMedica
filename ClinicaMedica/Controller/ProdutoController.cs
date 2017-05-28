using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.Controller
{
    class ProdutoController
    {
        DataModelContainer db = new DataModelContainer();

        public void Insert(Produto produto)
        {
            var erros = Validacao.ValidaProduto(produto);

            if (erros.Count() == 0)
            {
                try
                {
                    db.TB_Produto.Add(produto);
                    db.SaveChanges();
                    MessageBox.Show("Produto cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não foi possível cadastrar o produto!\n" + e.Message);
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
