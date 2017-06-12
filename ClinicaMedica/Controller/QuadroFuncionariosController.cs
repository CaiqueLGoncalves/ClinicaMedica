using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;

namespace ClinicaMedica.Controller
{
    class QuadroFuncionariosController
    {
        private DataModelContainer db = new DataModelContainer();

        public List<string> Insert(QuadroFuncionarios qf)
        {
            var erros = Validacao.Validar(qf);

            try
            {
                if (erros.Count() == 0)
                {
                    if (!AlreadyEmployed(qf.IdConsultorio, qf.IdFuncionario))
                    {
                        db.TB_QuadroFuncionarios.Add(qf);
                        db.SaveChanges();
                        return null;
                    }
                    else
                    {
                        throw new Exception("Este funcionário já está contratado pelo consultório especificado.");
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
                throw new Exception("Não foi possível contratar o funcionário!\n" + ex.Message);
            }
        }

        public List<string> ChangeStatus(QuadroFuncionarios qf)
        {
            var erros = Validacao.Validar(qf);

            try
            {
                if (erros.Count() == 0)
                {
                    db.Set<QuadroFuncionarios>().AddOrUpdate(qf);
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
                throw new Exception("Não foi possível alterar o status de atividade do funcionário!\n" + ex.ToString());
            }
        }

        public List<ConsultaQuadroFuncionarios> Select(bool exibirInativos)
        {
            IQueryable<ConsultaQuadroFuncionarios> query;

            if (exibirInativos)
            {
                query = from qf in db.TB_QuadroFuncionarios
                        orderby qf.IdConsultorio ascending
                        select new ConsultaQuadroFuncionarios
                        {
                            IdConsultorio = qf.IdConsultorio,
                            Consultorio = qf.Consultorio.NomeFantasia,
                            IdFuncionario = qf.IdFuncionario,
                            Funcionario = qf.Funcionario.Nome,
                            FuncFuncao = qf.Funcionario.Funcao.Nome,
                            DataAdmissao = (DateTime) DbFunctions.TruncateTime(qf.DataAdmissao),
                            DataDemissao = DbFunctions.TruncateTime(qf.DataDemissao),
                            Status = qf.Status
                        };
            }
            else
            {
                query = from qf in db.TB_QuadroFuncionarios
                        where qf.Status == true
                        orderby qf.IdConsultorio ascending
                        select new ConsultaQuadroFuncionarios
                        {
                            IdConsultorio = qf.IdConsultorio,
                            Consultorio = qf.Consultorio.NomeFantasia,
                            IdFuncionario = qf.IdFuncionario,
                            Funcionario = qf.Funcionario.Nome,
                            FuncFuncao = qf.Funcionario.Funcao.Nome,
                            DataAdmissao = (DateTime) DbFunctions.TruncateTime(qf.DataAdmissao),
                            DataDemissao = DbFunctions.TruncateTime(qf.DataDemissao),
                            Status = qf.Status
                        };
            }

            var resultado = query.ToList();
            return resultado;
        }

        public List<ConsultaQuadroFuncionarios> Select(string filtro, string pesquisa, bool exibirInativos)
        {
            IQueryable<ConsultaQuadroFuncionarios> query = null;

            switch (filtro)
            {
                case "CONSULTORIO":
                    {
                        if (exibirInativos)
                        {
                            query = from qf in db.TB_QuadroFuncionarios
                                    where qf.Consultorio.NomeFantasia.Contains(pesquisa)
                                    orderby qf.IdConsultorio ascending
                                    select new ConsultaQuadroFuncionarios
                                    {
                                        IdConsultorio = qf.IdConsultorio,
                                        Consultorio = qf.Consultorio.NomeFantasia,
                                        IdFuncionario = qf.IdFuncionario,
                                        Funcionario = qf.Funcionario.Nome,
                                        FuncFuncao = qf.Funcionario.Funcao.Nome,
                                        DataAdmissao = (DateTime)DbFunctions.TruncateTime(qf.DataAdmissao),
                                        DataDemissao = DbFunctions.TruncateTime(qf.DataDemissao),
                                        Status = qf.Status
                                    };
                        }
                        else
                        {
                            query = from qf in db.TB_QuadroFuncionarios
                                    where qf.Consultorio.NomeFantasia.Contains(pesquisa)
                                    where qf.Status == true
                                    orderby qf.IdConsultorio ascending
                                    select new ConsultaQuadroFuncionarios
                                    {
                                        IdConsultorio = qf.IdConsultorio,
                                        Consultorio = qf.Consultorio.NomeFantasia,
                                        IdFuncionario = qf.IdFuncionario,
                                        Funcionario = qf.Funcionario.Nome,
                                        FuncFuncao = qf.Funcionario.Funcao.Nome,
                                        DataAdmissao = (DateTime)DbFunctions.TruncateTime(qf.DataAdmissao),
                                        DataDemissao = DbFunctions.TruncateTime(qf.DataDemissao),
                                        Status = qf.Status
                                    };
                        }

                        break;
                    }
                case "FUNCIONARIO":
                    {
                        if (exibirInativos)
                        {
                            query = from qf in db.TB_QuadroFuncionarios
                                    where qf.Funcionario.Nome.Contains(pesquisa)
                                    orderby qf.IdConsultorio ascending
                                    select new ConsultaQuadroFuncionarios
                                    {
                                        IdConsultorio = qf.IdConsultorio,
                                        Consultorio = qf.Consultorio.NomeFantasia,
                                        IdFuncionario = qf.IdFuncionario,
                                        Funcionario = qf.Funcionario.Nome,
                                        FuncFuncao = qf.Funcionario.Funcao.Nome,
                                        DataAdmissao = (DateTime)DbFunctions.TruncateTime(qf.DataAdmissao),
                                        DataDemissao = DbFunctions.TruncateTime(qf.DataDemissao),
                                        Status = qf.Status
                                    };
                        }
                        else
                        {
                            query = from qf in db.TB_QuadroFuncionarios
                                    where qf.Funcionario.Nome.Contains(pesquisa)
                                    where qf.Status == true
                                    orderby qf.IdConsultorio ascending
                                    select new ConsultaQuadroFuncionarios
                                    {
                                        IdConsultorio = qf.IdConsultorio,
                                        Consultorio = qf.Consultorio.NomeFantasia,
                                        IdFuncionario = qf.IdFuncionario,
                                        Funcionario = qf.Funcionario.Nome,
                                        FuncFuncao = qf.Funcionario.Funcao.Nome,
                                        DataAdmissao = (DateTime)DbFunctions.TruncateTime(qf.DataAdmissao),
                                        DataDemissao = DbFunctions.TruncateTime(qf.DataDemissao),
                                        Status = qf.Status
                                    };
                        }

                        break;
                    }
            }

            var resultado = query.ToList();
            return resultado;
        }

        private bool AlreadyEmployed(int consultorio, int funcionario)
        {
            var query = db.TB_QuadroFuncionarios.Find(consultorio, funcionario);

            if (query == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}