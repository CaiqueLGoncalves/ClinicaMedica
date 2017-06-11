using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
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
            var erros = Validacao.Validar(exame);

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


        public List<ConsultaExame> Select()
        {
            var query = from exame in db.TB_Exame
                        orderby exame.IdExame ascending
                        select new ConsultaExame
                        {
                            IdExame = exame.IdExame,
                            Nome = exame.Nome,
                            Recomendacoes = exame.Recomendacoes
                            
                        };

            var resultado = query.ToList();
            return resultado;
        }

        public List<ConsultaExame> Select(string pesquisa)
        {
            IQueryable<ConsultaExame> query = null;            
                        query = from exame in db.TB_Exame
                                where exame.Nome.ToString().Contains(pesquisa)
                                
                                select new ConsultaExame
                                {
                                    IdExame = exame.IdExame,
                                    Nome = exame.Nome,
                                    Recomendacoes = exame.Recomendacoes
                                };
            var resultado = query.ToList();
            return resultado;
        }

        public List<string> Update(Exame exame)
        {
            var erros = Validacao.Validar(exame);

            try
            {
                if (erros.Count() == 0)
                {
                    db.Entry(exame).State = EntityState.Modified;
                    db.SaveChanges();
                    return null;
                }
                else
                {
                    List<string> listaErros = new List<string>();

                    foreach (var erro in erros)
                    {
                        listaErros.Add(erro.ErrorMessage);
                    }

                    return listaErros;
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var evError in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" possui os seguintes erros de validação: ",
                                       evError.Entry.Entity.GetType().Name,
                                       evError.Entry.State);

                    foreach (var valError in evError.ValidationErrors)
                    {
                        Console.WriteLine("- Propriedade: \"{0}\", Valor: \"{1}\", Erro: \"{2}\"",
                                          valError.PropertyName,
                                          evError.Entry.CurrentValues.GetValue<object>(valError.PropertyName),
                                          valError.ErrorMessage);
                    }
                }

                throw new Exception("Erro Interno. Por favor, contate o(s) administrador(es) do sistema.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível alterar o exame!\n" + ex.Message);
            }
        }

        public bool Delete(Exame exame)
        {
            try
            {
                exame = db.TB_Exame.Find(exame.IdExame);
                db.TB_Exame.Remove(exame);
                db.SaveChanges();
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var evError in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" possui os seguintes erros de validação: ",
                                       evError.Entry.Entity.GetType().Name,
                                       evError.Entry.State);

                    foreach (var valError in evError.ValidationErrors)
                    {
                        Console.WriteLine("- Propriedade: \"{0}\", Valor: \"{1}\", Erro: \"{2}\"",
                                          valError.PropertyName,
                                          evError.Entry.CurrentValues.GetValue<object>(valError.PropertyName),
                                          valError.ErrorMessage);
                    }
                }

                throw new Exception("Erro Interno. Por favor, contate o(s) administrador(es) do sistema.", ex);
            }
            catch (DbUpdateException)
            {
                throw new Exception("Não foi possível excluir este exame, pois o mesmo está atribuído a algum consultório.");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir esta função!\n" + ex.Message);
            }
        }

    }
}
