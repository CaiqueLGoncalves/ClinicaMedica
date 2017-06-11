using ClinicaMedica.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;

namespace ClinicaMedica.Controller
{
    class PacienteController
    {
        private DataModelContainer db = new DataModelContainer();

        public List<string> Insert(Paciente paciente)
        {
            var erros = Validacao.Validar(paciente);

            try
            {
                if (erros.Count() == 0)
                {
                    db.TB_Usuario.Add(paciente);
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
                throw new Exception("Não foi possível cadastrar o paciente!\n" + ex.Message);
            }
        }

        public List<string> Update(Paciente paciente, Localidade localidade)
        {
            var errosPaciente = Validacao.Validar(paciente);
            var errosLocalidade = Validacao.Validar(localidade);

            try
            {
                if (errosPaciente.Count() == 0 && errosLocalidade.Count() == 0)
                {
                    db.Set<Paciente>().AddOrUpdate(paciente);
                    db.Set<Localidade>().AddOrUpdate(localidade);
                    db.SaveChanges();
                    return null;
                }
                else
                {
                    List<string> listaErros = new List<string>();

                    foreach (var erro in errosPaciente)
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
                throw new Exception("Não foi possível alterar o paciente!\n" + ex.ToString());
            }
        }


        public bool Delete(Paciente paciente)
        {
            try
            {
                paciente = db.TB_Usuario_Paciente.Find(paciente.Identificacao);
                db.TB_Usuario_Paciente.Remove(paciente);
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
                throw new Exception("Não foi possível excluir este paciente, pois alguma consulta está agendada para o mesmo.");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir este paciente!\n" + ex.Message);
            }
        }

        public List<ConsultaPaciente> Select()
        {
            var query = from paciente in db.TB_Usuario_Paciente
                        orderby paciente.Identificacao ascending
                        select new ConsultaPaciente
                        {
                            Codigo = paciente.Identificacao,
                            Nome = paciente.Nome,
                            CPF = paciente.CPF,
                            RG = paciente.RG,
                            DataNascimento = paciente.DataNascimento,
                            Sexo = paciente.Sexo,
                            TelefoneResidencial = paciente.TelefoneResidencial,
                            TelefoneComercial = paciente.TelefoneComercial,
                            TelefoneCelular = paciente.TelefoneCelular,
                            Email = paciente.Email,
                            CEP = paciente.Localidade.CEP,
                            Endereco = paciente.Localidade.Endereco,
                            Numero = paciente.Localidade.Numero,
                            Complemento = paciente.Localidade.Complemento,
                            Bairro = paciente.Localidade.Bairro,
                            Cidade = paciente.Localidade.Cidade,
                            Estado = paciente.Localidade.Estado
                        };

            var resultado = query.ToList();
            return resultado;
        }

        public List<ConsultaPaciente> Select(string filtro, string pesquisa)
        {
            IQueryable<ConsultaPaciente> query = null;

            switch (filtro)
            {
                case "CODIGO":
                    {
                        query = from paciente in db.TB_Usuario_Paciente
                                where paciente.Identificacao.ToString().Contains(pesquisa)
                                orderby paciente.Identificacao ascending
                                select new ConsultaPaciente
                                {
                                    Codigo = paciente.Identificacao,
                                    Nome = paciente.Nome,
                                    CPF = paciente.CPF,
                                    RG = paciente.RG,
                                    DataNascimento = paciente.DataNascimento,
                                    Sexo = paciente.Sexo,
                                    TelefoneResidencial = paciente.TelefoneResidencial,
                                    TelefoneComercial = paciente.TelefoneComercial,
                                    TelefoneCelular = paciente.TelefoneCelular,
                                    Email = paciente.Email,
                                    CEP = paciente.Localidade.CEP,
                                    Endereco = paciente.Localidade.Endereco,
                                    Numero = paciente.Localidade.Numero,
                                    Complemento = paciente.Localidade.Complemento,
                                    Bairro = paciente.Localidade.Bairro,
                                    Cidade = paciente.Localidade.Cidade,
                                    Estado = paciente.Localidade.Estado
                                };

                        break;
                    }
                case "NOME":
                    {
                        query = from paciente in db.TB_Usuario_Paciente
                                where paciente.Nome.Contains(pesquisa)
                                orderby paciente.Identificacao ascending
                                select new ConsultaPaciente
                                {
                                    Codigo = paciente.Identificacao,
                                    Nome = paciente.Nome,
                                    CPF = paciente.CPF,
                                    RG = paciente.RG,
                                    DataNascimento = paciente.DataNascimento,
                                    Sexo = paciente.Sexo,
                                    TelefoneResidencial = paciente.TelefoneResidencial,
                                    TelefoneComercial = paciente.TelefoneComercial,
                                    TelefoneCelular = paciente.TelefoneCelular,
                                    Email = paciente.Email,
                                    CEP = paciente.Localidade.CEP,
                                    Endereco = paciente.Localidade.Endereco,
                                    Numero = paciente.Localidade.Numero,
                                    Complemento = paciente.Localidade.Complemento,
                                    Bairro = paciente.Localidade.Bairro,
                                    Cidade = paciente.Localidade.Cidade,
                                    Estado = paciente.Localidade.Estado
                                };

                        break;
                    }
                case "CPF":
                    {
                        query = from paciente in db.TB_Usuario_Paciente
                                where paciente.CPF.Contains(pesquisa)
                                orderby paciente.Identificacao ascending
                                select new ConsultaPaciente
                                {
                                    Codigo = paciente.Identificacao,
                                    Nome = paciente.Nome,
                                    CPF = paciente.CPF,
                                    RG = paciente.RG,
                                    DataNascimento = paciente.DataNascimento,
                                    Sexo = paciente.Sexo,
                                    TelefoneResidencial = paciente.TelefoneResidencial,
                                    TelefoneComercial = paciente.TelefoneComercial,
                                    TelefoneCelular = paciente.TelefoneCelular,
                                    Email = paciente.Email,
                                    CEP = paciente.Localidade.CEP,
                                    Endereco = paciente.Localidade.Endereco,
                                    Numero = paciente.Localidade.Numero,
                                    Complemento = paciente.Localidade.Complemento,
                                    Bairro = paciente.Localidade.Bairro,
                                    Cidade = paciente.Localidade.Cidade,
                                    Estado = paciente.Localidade.Estado
                                };

                        break;
                    }
            }

            var resultado = query.ToList();
            return resultado;
        }

        public Localidade FindLocalidade(int codigo)
        {
            Localidade l = db.TB_Usuario_Paciente.Find(codigo).Localidade;
            return l;
        }
    }
}