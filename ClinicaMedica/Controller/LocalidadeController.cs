using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace ClinicaMedica.Controller
{
    class LocalidadeController
    {
        private DataModelContainer db = new DataModelContainer();

        public bool Update(Localidade localidade)
        {
            var erros = Validacao.Validar(localidade);

            try
            {
                if (erros.Count() == 0)
                {
                    db.Entry(localidade).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
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

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível alterar a localidade!\n" + ex.Message);
                return false;
            }
        }
    }
}
