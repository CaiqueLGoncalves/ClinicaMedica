using ClinicaMedica.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;

namespace ClinicaMedica.Controller
{
    class FuncionarioController
    {
        private DataModelContainer db = new DataModelContainer();

        public List<string> Insert(Funcionario funcionario)
        {
            var erros = Validacao.Validar(funcionario);

            try
            {
                if (erros.Count() == 0)
                {
                    db.TB_Usuario.Add(funcionario);
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
                throw new Exception("Não foi possível cadastrar o funcionário!\n" + ex.Message);
            }
        }

        public List<string> Update(Funcionario funcionario, Localidade localidade)
        {
            var errosFuncionario = Validacao.Validar(funcionario);
            var errosLocalidade = Validacao.Validar(localidade);

            try
            {
                if (errosFuncionario.Count() == 0 && errosLocalidade.Count() == 0)
                {
                    db.Set<Funcionario>().AddOrUpdate(funcionario);
                    db.Set<Localidade>().AddOrUpdate(localidade);
                    db.SaveChanges();
                    return null;
                }
                else
                {
                    List<string> listaErros = new List<string>();

                    foreach (var erro in errosFuncionario)
                    {
                        listaErros.Add(erro.ErrorMessage);
                    }

                    foreach (var erro in errosLocalidade)
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
                throw new Exception("Não foi possível alterar o funcionário!\n" + ex.ToString());
            }
        }

        public bool Delete(Funcionario funcionario)
        {
            try
            {
                funcionario = db.TB_Usuario_Funcionario.Find(funcionario.Identificacao);
                db.TB_Usuario_Funcionario.Remove(funcionario);
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
                throw new Exception("Não foi possível excluir este funcionário.");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir este funcionário!\n" + ex.Message);
            }
        }

        public List<ConsultaFuncionario> Select()
        {
            var query = from funcionario in db.TB_Usuario_Funcionario
                        where funcionario.Funcao.Nome != "Médico"
                        orderby funcionario.Identificacao ascending
                        select new ConsultaFuncionario
                        {
                            Codigo = funcionario.Identificacao,
                            Nome = funcionario.Nome,
                            CPF = funcionario.CPF,
                            RG = funcionario.RG,
                            DataNascimento = funcionario.DataNascimento,
                            Sexo = funcionario.Sexo,
                            Funcao = funcionario.Funcao.Nome,
                            TelefoneResidencial = funcionario.TelefoneResidencial,
                            TelefoneComercial = funcionario.TelefoneComercial,
                            TelefoneCelular = funcionario.TelefoneCelular,
                            Email = funcionario.Email,
                            CEP = funcionario.Localidade.CEP,
                            Endereco = funcionario.Localidade.Endereco,
                            Numero = funcionario.Localidade.Numero,
                            Complemento = funcionario.Localidade.Complemento,
                            Bairro = funcionario.Localidade.Bairro,
                            Cidade = funcionario.Localidade.Cidade,
                            Estado = funcionario.Localidade.Estado
                        };

            var resultado = query.ToList();
            return resultado;
        }

        public List<ConsultaFuncionario> SelectWithMedico()
        {
            var query = from funcionario in db.TB_Usuario_Funcionario
                        orderby funcionario.Identificacao ascending
                        select new ConsultaFuncionario
                        {
                            Codigo = funcionario.Identificacao,
                            Nome = funcionario.Nome,
                            CPF = funcionario.CPF,
                            RG = funcionario.RG,
                            DataNascimento = funcionario.DataNascimento,
                            Sexo = funcionario.Sexo,
                            Funcao = funcionario.Funcao.Nome,
                            TelefoneResidencial = funcionario.TelefoneResidencial,
                            TelefoneComercial = funcionario.TelefoneComercial,
                            TelefoneCelular = funcionario.TelefoneCelular,
                            Email = funcionario.Email,
                            CEP = funcionario.Localidade.CEP,
                            Endereco = funcionario.Localidade.Endereco,
                            Numero = funcionario.Localidade.Numero,
                            Complemento = funcionario.Localidade.Complemento,
                            Bairro = funcionario.Localidade.Bairro,
                            Cidade = funcionario.Localidade.Cidade,
                            Estado = funcionario.Localidade.Estado
                        };

            var resultado = query.ToList();
            return resultado;
        }

        public List<ConsultaFuncionario> Select(string filtro, string pesquisa)
        {
            IQueryable<ConsultaFuncionario> query = null;

            switch (filtro)
            {
                case "CODIGO":
                    {
                        query = from funcionario in db.TB_Usuario_Funcionario
                                where funcionario.Funcao.Nome != "Médico"
                                where funcionario.Identificacao.ToString().Contains(pesquisa)
                                orderby funcionario.Identificacao ascending
                                select new ConsultaFuncionario
                                {
                                    Codigo = funcionario.Identificacao,
                                    Nome = funcionario.Nome,
                                    CPF = funcionario.CPF,
                                    RG = funcionario.RG,
                                    DataNascimento = funcionario.DataNascimento,
                                    Sexo = funcionario.Sexo,
                                    Funcao = funcionario.Funcao.Nome,
                                    TelefoneResidencial = funcionario.TelefoneResidencial,
                                    TelefoneComercial = funcionario.TelefoneComercial,
                                    TelefoneCelular = funcionario.TelefoneCelular,
                                    Email = funcionario.Email,
                                    CEP = funcionario.Localidade.CEP,
                                    Endereco = funcionario.Localidade.Endereco,
                                    Numero = funcionario.Localidade.Numero,
                                    Complemento = funcionario.Localidade.Complemento,
                                    Bairro = funcionario.Localidade.Bairro,
                                    Cidade = funcionario.Localidade.Cidade,
                                    Estado = funcionario.Localidade.Estado
                                };

                        break;
                    }
                case "NOME":
                    {
                        query = from funcionario in db.TB_Usuario_Funcionario
                                where funcionario.Funcao.Nome != "Médico"
                                where funcionario.Nome.Contains(pesquisa)
                                orderby funcionario.Identificacao ascending
                                select new ConsultaFuncionario
                                {
                                    Codigo = funcionario.Identificacao,
                                    Nome = funcionario.Nome,
                                    CPF = funcionario.CPF,
                                    RG = funcionario.RG,
                                    DataNascimento = funcionario.DataNascimento,
                                    Sexo = funcionario.Sexo,
                                    Funcao = funcionario.Funcao.Nome,
                                    TelefoneResidencial = funcionario.TelefoneResidencial,
                                    TelefoneComercial = funcionario.TelefoneComercial,
                                    TelefoneCelular = funcionario.TelefoneCelular,
                                    Email = funcionario.Email,
                                    CEP = funcionario.Localidade.CEP,
                                    Endereco = funcionario.Localidade.Endereco,
                                    Numero = funcionario.Localidade.Numero,
                                    Complemento = funcionario.Localidade.Complemento,
                                    Bairro = funcionario.Localidade.Bairro,
                                    Cidade = funcionario.Localidade.Cidade,
                                    Estado = funcionario.Localidade.Estado
                                };

                        break;
                    }
                case "CPF":
                    {
                        query = from funcionario in db.TB_Usuario_Funcionario
                                where funcionario.Funcao.Nome != "Médico"
                                where funcionario.CPF.Contains(pesquisa)
                                orderby funcionario.Identificacao ascending
                                select new ConsultaFuncionario
                                {
                                    Codigo = funcionario.Identificacao,
                                    Nome = funcionario.Nome,
                                    CPF = funcionario.CPF,
                                    RG = funcionario.RG,
                                    DataNascimento = funcionario.DataNascimento,
                                    Sexo = funcionario.Sexo,
                                    Funcao = funcionario.Funcao.Nome,
                                    TelefoneResidencial = funcionario.TelefoneResidencial,
                                    TelefoneComercial = funcionario.TelefoneComercial,
                                    TelefoneCelular = funcionario.TelefoneCelular,
                                    Email = funcionario.Email,
                                    CEP = funcionario.Localidade.CEP,
                                    Endereco = funcionario.Localidade.Endereco,
                                    Numero = funcionario.Localidade.Numero,
                                    Complemento = funcionario.Localidade.Complemento,
                                    Bairro = funcionario.Localidade.Bairro,
                                    Cidade = funcionario.Localidade.Cidade,
                                    Estado = funcionario.Localidade.Estado
                                };

                        break;
                    }
            }

            var resultado = query.ToList();
            return resultado;
        }

        public Localidade FindLocalidade(int codigo)
        {
            Localidade l = db.TB_Usuario_Funcionario.Find(codigo).Localidade;
            return l;
        }
    }
}