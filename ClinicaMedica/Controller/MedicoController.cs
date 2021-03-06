﻿using ClinicaMedica.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;

namespace ClinicaMedica.Controller
{
    class MedicoController
    {
        private DataModelContainer db = new DataModelContainer();

        public List<string> Insert(Medico medico)
        {
            var erros = Validacao.ValidarUsuario(medico);

            try
            {
                if (erros.Count() == 0)
                {
                    db.TB_Usuario.Add(medico);
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
                throw new Exception("Não foi possível cadastrar o médico!\n" + ex.Message);
            }
        }

        public List<string> Update(Medico medico, Localidade localidade)
        {
            var errosMedico = Validacao.ValidarUsuario(medico);
            var errosLocalidade = Validacao.Validar(localidade);

            try
            {
                if (errosMedico.Count() == 0 && errosLocalidade.Count() == 0)
                {
                    db.Set<Medico>().AddOrUpdate(medico);
                    db.Set<Localidade>().AddOrUpdate(localidade);
                    db.SaveChanges();
                    return null;
                }
                else
                {
                    List<string> listaErros = new List<string>();

                    foreach (var erro in errosMedico)
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
                throw new Exception("Não foi possível alterar o médico!\n" + ex.ToString());
            }
        }

        public bool Delete(Medico medico)
        {
            try
            {
                medico = db.TB_Usuario_Medico.Find(medico.Identificacao);
                db.TB_Usuario_Medico.Remove(medico);
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
                throw new Exception("Não foi possível excluir este médico, pois alguma consulta está alocada para o mesmo.");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir este médico!\n" + ex.Message);
            }
        }

        public List<ConsultaMedico> Select()
        {
            var query = from medico in db.TB_Usuario_Medico
                        orderby medico.Identificacao ascending
                        select new ConsultaMedico
                        {
                            Codigo = medico.Identificacao,
                            Nome = medico.Nome,
                            CPF = medico.CPF,
                            RG = medico.RG,
                            CRM = medico.CRM,
                            DataNascimento = medico.DataNascimento,
                            Sexo = medico.Sexo,
                            TelefoneResidencial = medico.TelefoneResidencial,
                            TelefoneComercial = medico.TelefoneComercial,
                            TelefoneCelular = medico.TelefoneCelular,
                            Email = medico.Email,
                            CEP = medico.Localidade.CEP,
                            Endereco = medico.Localidade.Endereco,
                            Numero = medico.Localidade.Numero,
                            Complemento = medico.Localidade.Complemento,
                            Bairro = medico.Localidade.Bairro,
                            Cidade = medico.Localidade.Cidade,
                            Estado = medico.Localidade.Estado
                        };

            var resultado = query.ToList();
            return resultado;
        }

        public List<ConsultaMedico> Select(string filtro, string pesquisa)
        {
            IQueryable<ConsultaMedico> query = null;

            switch (filtro)
            {
                case "CODIGO":
                    {
                        query = from medico in db.TB_Usuario_Medico
                                where medico.Identificacao.ToString().Contains(pesquisa)
                                orderby medico.Identificacao ascending
                                select new ConsultaMedico
                                {
                                    Codigo = medico.Identificacao,
                                    Nome = medico.Nome,
                                    CPF = medico.CPF,
                                    RG = medico.RG,
                                    CRM = medico.CRM,
                                    DataNascimento = medico.DataNascimento,
                                    Sexo = medico.Sexo,
                                    TelefoneResidencial = medico.TelefoneResidencial,
                                    TelefoneComercial = medico.TelefoneComercial,
                                    TelefoneCelular = medico.TelefoneCelular,
                                    Email = medico.Email,
                                    CEP = medico.Localidade.CEP,
                                    Endereco = medico.Localidade.Endereco,
                                    Numero = medico.Localidade.Numero,
                                    Complemento = medico.Localidade.Complemento,
                                    Bairro = medico.Localidade.Bairro,
                                    Cidade = medico.Localidade.Cidade,
                                    Estado = medico.Localidade.Estado
                                };

                        break;
                    }
                case "NOME":
                    {
                        query = from medico in db.TB_Usuario_Medico
                                where medico.Nome.Contains(pesquisa)
                                orderby medico.Identificacao ascending
                                select new ConsultaMedico
                                {
                                    Codigo = medico.Identificacao,
                                    Nome = medico.Nome,
                                    CPF = medico.CPF,
                                    RG = medico.RG,
                                    CRM = medico.CRM,
                                    DataNascimento = medico.DataNascimento,
                                    Sexo = medico.Sexo,
                                    TelefoneResidencial = medico.TelefoneResidencial,
                                    TelefoneComercial = medico.TelefoneComercial,
                                    TelefoneCelular = medico.TelefoneCelular,
                                    Email = medico.Email,
                                    CEP = medico.Localidade.CEP,
                                    Endereco = medico.Localidade.Endereco,
                                    Numero = medico.Localidade.Numero,
                                    Complemento = medico.Localidade.Complemento,
                                    Bairro = medico.Localidade.Bairro,
                                    Cidade = medico.Localidade.Cidade,
                                    Estado = medico.Localidade.Estado
                                };

                        break;
                    }
                case "CPF":
                    {
                        query = from medico in db.TB_Usuario_Medico
                                where medico.CPF.Contains(pesquisa)
                                orderby medico.Identificacao ascending
                                select new ConsultaMedico
                                {
                                    Codigo = medico.Identificacao,
                                    Nome = medico.Nome,
                                    CPF = medico.CPF,
                                    RG = medico.RG,
                                    CRM = medico.CRM,
                                    DataNascimento = medico.DataNascimento,
                                    Sexo = medico.Sexo,
                                    TelefoneResidencial = medico.TelefoneResidencial,
                                    TelefoneComercial = medico.TelefoneComercial,
                                    TelefoneCelular = medico.TelefoneCelular,
                                    Email = medico.Email,
                                    CEP = medico.Localidade.CEP,
                                    Endereco = medico.Localidade.Endereco,
                                    Numero = medico.Localidade.Numero,
                                    Complemento = medico.Localidade.Complemento,
                                    Bairro = medico.Localidade.Bairro,
                                    Cidade = medico.Localidade.Cidade,
                                    Estado = medico.Localidade.Estado
                                };

                        break;
                    }
                case "CRM":
                    {
                        query = from medico in db.TB_Usuario_Medico
                                where medico.CRM.Contains(pesquisa)
                                orderby medico.Identificacao ascending
                                select new ConsultaMedico
                                {
                                    Codigo = medico.Identificacao,
                                    Nome = medico.Nome,
                                    CPF = medico.CPF,
                                    RG = medico.RG,
                                    CRM = medico.CRM,
                                    DataNascimento = medico.DataNascimento,
                                    Sexo = medico.Sexo,
                                    TelefoneResidencial = medico.TelefoneResidencial,
                                    TelefoneComercial = medico.TelefoneComercial,
                                    TelefoneCelular = medico.TelefoneCelular,
                                    Email = medico.Email,
                                    CEP = medico.Localidade.CEP,
                                    Endereco = medico.Localidade.Endereco,
                                    Numero = medico.Localidade.Numero,
                                    Complemento = medico.Localidade.Complemento,
                                    Bairro = medico.Localidade.Bairro,
                                    Cidade = medico.Localidade.Cidade,
                                    Estado = medico.Localidade.Estado
                                };

                        break;
                    }
            }

            var resultado = query.ToList();
            return resultado;
        }

        public Localidade FindLocalidade(int codigo)
        {
            Localidade l = db.TB_Usuario_Medico.Find(codigo).Localidade;
            return l;
        }
    }
}