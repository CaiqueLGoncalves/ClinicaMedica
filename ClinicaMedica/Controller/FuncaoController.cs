using ClinicaMedica.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace ClinicaMedica.Controller
{
    class FuncaoController
    {
        private DataModelContainer db = new DataModelContainer();

        public List<string> Insert(Funcao funcao)
        {
            var erros = Validacao.Validar(funcao);

            try
            {
                if (erros.Count() == 0)
                {
                    db.TB_Funcao.Add(funcao);
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
                throw new Exception("Não foi possível cadastrar a função!\n" + ex.Message);
            }
        }
    }
}
