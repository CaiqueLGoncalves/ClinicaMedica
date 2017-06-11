using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Controller
{
    class ExameAgendarController
    {
        private DataModelContainer db = new DataModelContainer();

        public List<string> Insert(AgendaExame agendaexame)
        {
            var erros = Validacao.Validar(agendaexame);

            try
            {
                if (erros.Count() == 0)
                {
                    if (IsAvailable(agendaexame.DataHoraInicio, agendaexame.DataHoraFim))
                    {
                        db.TB_AgendaExame.Add(agendaexame);
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
                throw new Exception("Não foi possível cadastrar o exame!\n" + ex.Message);
            }
        }



        public List<ConsultaAgendaExame> Select()
        {
            var query = from agendaexame in db.TB_AgendaExame
                        orderby agendaexame.DataHoraInicio ascending
                        select new ConsultaAgendaExame
                        {
                            IdAgendaExame = agendaexame.IdAgendaExame,
                            IdExame = agendaexame.IdExame,
                            IdConsultorio = agendaexame.IdConsultorio,
                            IdentificacaoPaciente = agendaexame.IdentificacaoPaciente,
                            Consultorio = agendaexame.Consultorio.NomeFantasia,
                            Paciente = agendaexame.Paciente.Nome,
                            Exame = agendaexame.Exame.Nome,
                            DataHoraInicio = agendaexame.DataHoraInicio,
                            DataHoraFim = agendaexame.DataHoraFim,
                            Comparecimento = agendaexame.Comparecimento,
                            Anotacoes = agendaexame.Anotacoes
                            //                            DataHoraInicio = (TimeSpan)DbFunctions.CreateTime(agendaexame.DataHoraInicio.Hour, agendaexame.DataHoraInicio.Minute, agendaexame.DataHoraInicio.Second),
                            //                            DataHoraFim = (TimeSpan)DbFunctions.CreateTime(agendaexame.DataHoraFim.Hour, agendaexame.DataHoraFim.Minute, agendaexame.DataHoraFim.Second),
                        };

            var resultado = query.ToList();
            return resultado;
        }


        public List<ConsultaAgendaExame> Select(DateTime data, int consultorio, int exame)
        {
            var query = from agendaexame in db.TB_AgendaExame
                        where DbFunctions.TruncateTime(agendaexame.DataHoraInicio) == data.Date
                        where DbFunctions.TruncateTime(agendaexame.DataHoraFim) == data.Date
                        where agendaexame.IdConsultorio == consultorio
                        where agendaexame.IdExame == exame
                        orderby agendaexame.DataHoraInicio ascending
                        select new ConsultaAgendaExame
                        {
                            IdAgendaExame = agendaexame.IdAgendaExame,
                            IdExame = agendaexame.IdExame,
                            IdConsultorio = agendaexame.IdConsultorio,
                            IdentificacaoPaciente = agendaexame.IdentificacaoPaciente,
                            Consultorio = agendaexame.Consultorio.NomeFantasia,
                            Paciente = agendaexame.Paciente.Nome,
                            Exame = agendaexame.Exame.Nome,
                            DataHoraInicio = agendaexame.DataHoraInicio,
                            DataHoraFim = agendaexame.DataHoraFim,
                            Comparecimento = agendaexame.Comparecimento,
                            Anotacoes = agendaexame.Anotacoes
                            //                            DataHoraInicio = (TimeSpan)DbFunctions.CreateTime(agendaexame.DataHoraInicio.Hour, agendaexame.DataHoraInicio.Minute, agendaexame.DataHoraInicio.Second),
                            //                            DataHoraFim = (TimeSpan)DbFunctions.CreateTime(agendaexame.DataHoraFim.Hour, agendaexame.DataHoraFim.Minute, agendaexame.DataHoraFim.Second),
                        };

            var resultado = query.ToList();
            return resultado;
        }

        public List<ConsultaAgendaExame> Select(string filtro, string pesquisa)
        {
            IQueryable<ConsultaAgendaExame> query = null;

            switch (filtro)
            {


                case "EXAME":
                    {
                        query = from agendaexame in db.TB_AgendaExame
                                join exame in db.TB_Exame on agendaexame.IdExame equals exame.IdExame
                                where exame.Nome.ToString().Contains(pesquisa)
                                orderby agendaexame.DataHoraInicio ascending
                                    select new ConsultaAgendaExame
                                    {
                                        IdAgendaExame = agendaexame.IdAgendaExame,
                                        IdExame = agendaexame.IdExame,
                                        IdConsultorio = agendaexame.IdConsultorio,
                                        IdentificacaoPaciente = agendaexame.IdentificacaoPaciente,
                                        Consultorio = agendaexame.Consultorio.NomeFantasia,
                                        Paciente = agendaexame.Paciente.Nome,
                                        Exame = agendaexame.Exame.Nome,
                                        DataHoraInicio = agendaexame.DataHoraInicio,
                                        DataHoraFim = agendaexame.DataHoraFim,
                                        Comparecimento = agendaexame.Comparecimento,
                                        Anotacoes = agendaexame.Anotacoes
                        };
                        break;
                    }
                case "CONSULTORIO":
                    {
                        query = from agendaexame in db.TB_AgendaExame
                                join consultorio in db.TB_Consultorio on agendaexame.IdConsultorio equals consultorio.IdConsultorio
                                where consultorio.NomeFantasia.ToString().Contains(pesquisa)
                                orderby agendaexame.DataHoraInicio ascending
                                select new ConsultaAgendaExame
                                {
                                    IdAgendaExame = agendaexame.IdAgendaExame,
                                    IdExame = agendaexame.IdExame,
                                    IdConsultorio = agendaexame.IdConsultorio,
                                    IdentificacaoPaciente = agendaexame.IdentificacaoPaciente,
                                    Consultorio = agendaexame.Consultorio.NomeFantasia,
                                    Paciente = agendaexame.Paciente.Nome,
                                    Exame = agendaexame.Exame.Nome,
                                    DataHoraInicio = agendaexame.DataHoraInicio,
                                    DataHoraFim = agendaexame.DataHoraFim,
                                    Comparecimento = agendaexame.Comparecimento,
                                    Anotacoes = agendaexame.Anotacoes
                                };
                        break;
                    }
                case "NOME":
                    {
                        query = from agendaexame in db.TB_AgendaExame
                                join paciente in db.TB_Usuario_Paciente on agendaexame.IdentificacaoPaciente equals paciente.Identificacao
                                where paciente.Nome.ToString().Contains(pesquisa)
                                orderby agendaexame.DataHoraInicio ascending
                                select new ConsultaAgendaExame
                                {
                                    IdAgendaExame = agendaexame.IdAgendaExame,
                                    IdExame = agendaexame.IdExame,
                                    IdConsultorio = agendaexame.IdConsultorio,
                                    IdentificacaoPaciente = agendaexame.IdentificacaoPaciente,
                                    Consultorio = agendaexame.Consultorio.NomeFantasia,
                                    Paciente = agendaexame.Paciente.Nome,
                                    Exame = agendaexame.Exame.Nome,
                                    DataHoraInicio = agendaexame.DataHoraInicio,
                                    DataHoraFim = agendaexame.DataHoraFim,
                                    Comparecimento = agendaexame.Comparecimento,
                                    Anotacoes = agendaexame.Anotacoes
                                };
                        break;
                    }

            }

            var resultado = query.ToList();
            return resultado;
        }

        public List<string> Update(AgendaExame agendaexame)
        {
            var erros = Validacao.Validar(agendaexame);

            try
            {
                if (erros.Count() == 0)
                {
                    if (IsAvailable(agendaexame.DataHoraInicio, agendaexame.DataHoraFim))
                    {
                        db.Entry(agendaexame).State = EntityState.Modified;
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
                throw new Exception("Não foi possível alterar o exame!\n" + ex.Message);
            }
        }

        public bool Delete(AgendaExame agendaexame)
        {
            try
            {
                agendaexame = db.TB_AgendaExame.Find(agendaexame.IdAgendaExame);
                db.TB_AgendaExame.Remove(agendaexame);
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




        private bool IsAvailable(DateTime inicio, DateTime final)
        {
            var query = from c in db.TB_AgendaExame
                        where c.DataHoraInicio <= final
                        where c.DataHoraFim >= inicio
                        select c;

            if (query.Count() == 0)
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
