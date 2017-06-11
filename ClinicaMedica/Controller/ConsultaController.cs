using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace ClinicaMedica.Controller
{
    class ConsultaController
    {
        private DataModelContainer db = new DataModelContainer();

        public List<string> Insert(Consulta consulta)
        {
            var erros = Validacao.Validar(consulta);

            try
            {
                if (erros.Count() == 0)
                {
                    if (IsAvailable(consulta.DataHoraInicio, consulta.DataHoraFim))
                    {
                        db.TB_Consulta.Add(consulta);
                        db.SaveChanges();
                        return null;
                    }
                    else
                    {
                        throw new Exception("Horário Indisponível!");
                    }
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
                throw new Exception("Não foi possível cadastrar a especialidade!\n" + ex.Message);
            }
        }

        public List<ConsultaConsulta> Select(DateTime data, int consultorio)
        {
            var query = from consulta in db.TB_Consulta
                        where DbFunctions.TruncateTime(consulta.DataHoraInicio) == data.Date
                        where DbFunctions.TruncateTime(consulta.DataHoraFim) == data.Date
                        where consulta.IdConsultorio == consultorio
                        orderby consulta.DataHoraInicio ascending
                        select new ConsultaConsulta
                        {
                            Codigo = consulta.IdConsulta,
                            Inicio = (TimeSpan)DbFunctions.CreateTime(consulta.DataHoraInicio.Hour, consulta.DataHoraInicio.Minute, consulta.DataHoraInicio.Second),
                            Final = (TimeSpan)DbFunctions.CreateTime(consulta.DataHoraFim.Hour, consulta.DataHoraFim.Minute, consulta.DataHoraFim.Second),
                            Paciente = consulta.Paciente.Nome,
                            Medico = consulta.Medico.Nome,
                            Comparecimento = consulta.Comparecimento
                        };

            var resultado = query.ToList();
            return resultado;
        }

        private bool IsAvailable(DateTime inicio, DateTime final)
        {
            var query = from c in db.TB_Consulta
                        where c.DataHoraInicio <= final
                        where c.DataHoraFim >= inicio
                        select c;

            if(query.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
