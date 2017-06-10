using ClinicaMedica.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Validation;


namespace ClinicaMedica.Controller
{
    class MedicoEspecialidadeController
    {
        private DataModelContainer db = new DataModelContainer();

        public int Insert(MedicoEspecialidade medicoEspecialidade)
        {
            var erros = Validacao.Validar(medicoEspecialidade);

            try
            {
                if (erros.Count() == 0)
                {
                    db.TB_MedicoEspecialidade.Add(medicoEspecialidade);
                    db.SaveChanges();
                    return 0;
                }
                else
                {
                    return erros.Count();
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
                throw new Exception("Não foi possível adicionar esta especialidade ao médico!\n" + ex.Message);
            }
        }

        public List<int> Select(int identificacaoMedico)
        {
            var query = from me in db.TB_MedicoEspecialidade
                        where me.IdentificacaoMedico == identificacaoMedico
                        orderby me.IdEspecialidade ascending
                        select me.IdEspecialidade;

            var resultado = query.ToList();

            return resultado;
        }
    }
}