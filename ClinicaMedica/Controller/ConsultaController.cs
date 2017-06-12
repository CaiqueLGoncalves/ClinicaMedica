using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
                    string disponibilidade = IsAvailable(consulta.DataHoraInicio, consulta.DataHoraFim, consulta.IdConsultorio, consulta.IdentificacaoMedico, consulta.IdentificacaoPaciente);

                    if (disponibilidade == null)
                    {
                        db.TB_Consulta.Add(consulta);
                        db.SaveChanges();
                        return null;
                    }
                    else
                    {
                        throw new Exception(disponibilidade);
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
                throw new Exception("Não foi possível agendar a consulta!\n" + ex.Message);
            }
        }

        public List<string> Update(Consulta consulta)
        {
            var erros = Validacao.Validar(consulta);

            try
            {
                if (erros.Count() == 0)
                {
                    string disponibilidade = IsAvailable(consulta.DataHoraInicio, consulta.DataHoraFim, consulta.IdConsultorio, consulta.IdentificacaoMedico, consulta.IdentificacaoPaciente, consulta.IdConsulta);

                    if (disponibilidade == null)
                    {
                        db.Set<Consulta>().AddOrUpdate(consulta);
                        db.SaveChanges();
                        return null;
                    }
                    else
                    {
                        throw new Exception(disponibilidade);
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
                throw new Exception("Não foi possível alterar a consulta!\n" + ex.Message);
            }
        }

        public bool Delete(Consulta consulta)
        {
            try
            {
                consulta = db.TB_Consulta.Find(consulta.IdConsulta);
                db.TB_Consulta.Remove(consulta);
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
            catch (Exception ex)
            {
                throw new Exception("Não foi possível desmarcar esta consulta!\n" + ex.Message);
            }
        }

        public Consulta Select(int idConsulta)
        {
            Consulta consulta = db.TB_Consulta.Find(idConsulta);
            return consulta;
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

        private string IsAvailable(DateTime inicio, DateTime final, int consultorio, int medico, int paciente)
        {
            var query = from c in db.TB_Consulta
                        where c.IdConsultorio == consultorio
                        where c.DataHoraInicio <= final
                        where c.DataHoraFim >= inicio
                        select c;

            if (query.Count() == 0)
            {
                query = from c in db.TB_Consulta
                        where c.IdentificacaoMedico == medico
                        where c.DataHoraInicio <= final
                        where c.DataHoraFim >= inicio
                        select c;

                if (query.Count() == 0)
                {
                    query = from c in db.TB_Consulta
                            where c.IdentificacaoPaciente == paciente
                            where c.DataHoraInicio <= final
                            where c.DataHoraFim >= inicio
                            select c;

                    if (query.Count() == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return "Existe consulta agendada para este paciente no horário especificado.";
                    }
                }
                else
                {
                    return "O médico selecionado estará indisponível no horário especificado.";
                }
            }
            else
            {
                return "O consultório estará ocupado no horário especificado.";
            }
        }

        private string IsAvailable(DateTime inicio, DateTime final, int consultorio, int medico, int paciente, int consulta)
        {
            // Verificação de Disponbilidade de Consultório

            bool estado = false;
            var query = (from c in db.TB_Consulta
                         where c.IdConsultorio == consultorio
                         where c.DataHoraInicio <= final
                         where c.DataHoraFim >= inicio
                         select c).ToList();

            if (query.Count == 0)
            {
                estado = true;
            }
            else if (query.Count == 1)
            {
                if (query[0].IdConsulta == consulta)
                {
                    estado = true;
                }
                else
                {
                    return "O consultório estará ocupado no horário especificado.";
                }
            }
            else
            {
                return "O consultório estará ocupado no horário especificado.";
            }

            // Verificação de Disponibilidade de Médico

            if (estado == true)
            {
                estado = false;
                query = (from c in db.TB_Consulta
                         where c.IdentificacaoMedico == medico
                         where c.DataHoraInicio <= final
                         where c.DataHoraFim >= inicio
                         select c).ToList();

                if (query.Count == 0)
                {
                    estado = true;
                }
                else if (query.Count == 1)
                {
                    if (query[0].IdConsulta == consulta)
                    {
                        estado = true;
                    }
                    else
                    {
                        return "O médico selecionado estará indisponível no horário especificado.";
                    }
                }
                else
                {
                    return "O médico selecionado estará indisponível no horário especificado.";
                }
            }

            // Verificação de Disponibilidade de Paciente

            if (estado == true)
            {
                estado = false;
                query = (from c in db.TB_Consulta
                         where c.IdentificacaoPaciente == paciente
                         where c.DataHoraInicio <= final
                         where c.DataHoraFim >= inicio
                         select c).ToList();

                if (query.Count == 0)
                {
                    estado = true;
                }
                else if (query.Count == 1)
                {
                    if (query[0].IdConsulta == consulta)
                    {
                        estado = true;
                    }
                    else
                    {
                        return "Existe consulta agendada para este paciente no horário especificado.";
                    }
                }
                else
                {
                    return "Existe consulta agendada para este paciente no horário especificado.";
                }
            }

            // Verificação Geral de Disponibilidade

            if (estado == true)
            {
                return null;
            }
            else
            {
                return "Não foi possível agendar/alterar esta consulta.";
            }
        }
    }
}