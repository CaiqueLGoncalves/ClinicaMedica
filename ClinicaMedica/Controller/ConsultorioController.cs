using ClinicaMedica.Model;
using ClinicaMedica.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.Controller
{
    class ConsultorioController
    {
        private DataModelContainer db = new DataModelContainer();

        public void Insert(Consultorio consultorio)
        {

                var erros = Validacao.Validar(consultorio);


                if (erros.Count() == 0)
                {
                    try
                    {
                        db.TB_Consultorio.Add(consultorio);
                        db.SaveChanges();
                        MessageBox.Show("Consultório cadastrado com sucesso!");
                    }

                catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível cadastrar o consultório!\n" + e.Message);
                    }
                  //  CadastroCargo.ActiveForm.Close();

                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }
            
        }

        public List<ConsultaConsultorio> Select()
        {
            var query = from consultorio in db.TB_Consultorio
                        orderby consultorio.IdConsultorio ascending
                        select new ConsultaConsultorio
                        {
                            IdConsultorio = consultorio.IdConsultorio,
                            NomeFantasia = consultorio.NomeFantasia,
                            RazaoSocial = consultorio.RazaoSocial,
                            CNPJ = consultorio.CNPJ,
                            HorarioAbertura = consultorio.HorarioAbertura,
                            HorarioFechamento = consultorio.HorarioFechamento,
                            Telefone = consultorio.Telefone,
                            CEP = consultorio.Localidade.CEP,
                            Endereco = consultorio.Localidade.Endereco,
                            Numero = consultorio.Localidade.Numero,
                            Complemento = consultorio.Localidade.Complemento,
                            Bairro = consultorio.Localidade.Bairro,
                            Cidade = consultorio.Localidade.Cidade,
                            Estado = consultorio.Localidade.Estado
                        };

            var resultado = query.ToList();
            return resultado;
        }

        public Consultorio Select(int idConsultorio)
        {
            Consultorio consultorio = db.TB_Consultorio.Find(idConsultorio);
            return consultorio;
        }

        public List<ConsultaConsultorio> Select(string filtro, string pesquisa)
        {
            IQueryable<ConsultaConsultorio> query = null;

            switch (filtro)
            {
                case "NOME":
                    {
                        query = from consultorio in db.TB_Consultorio
                                where consultorio.NomeFantasia.ToString().Contains(pesquisa)
                                orderby consultorio.NomeFantasia ascending
                                select new ConsultaConsultorio
                                {
                                    IdConsultorio = consultorio.IdConsultorio,
                                    NomeFantasia = consultorio.NomeFantasia,
                                    RazaoSocial = consultorio.RazaoSocial,
                                    CNPJ = consultorio.CNPJ,
                                    Telefone = consultorio.Telefone,
                                    HorarioAbertura = consultorio.HorarioAbertura,
                                    HorarioFechamento = consultorio.HorarioFechamento,
                                    CEP = consultorio.Localidade.CEP,
                                    Endereco = consultorio.Localidade.Endereco,
                                    Numero = consultorio.Localidade.Numero,
                                    Complemento = consultorio.Localidade.Complemento,
                                    Bairro = consultorio.Localidade.Bairro,
                                    Cidade = consultorio.Localidade.Cidade,
                                    Estado = consultorio.Localidade.Estado
                                };

                        break;
                    }
                case "CIDADE":
                    {
                        query = from consultorio in db.TB_Consultorio
                                where consultorio.Localidade.Cidade.ToString().Contains(pesquisa)
                                orderby consultorio.NomeFantasia ascending
                                select new ConsultaConsultorio
                                {
                                    IdConsultorio = consultorio.IdConsultorio,
                                    NomeFantasia = consultorio.NomeFantasia,
                                    RazaoSocial = consultorio.RazaoSocial,
                                    CNPJ = consultorio.CNPJ,
                                    Telefone = consultorio.Telefone,
                                    HorarioAbertura = consultorio.HorarioAbertura,
                                    HorarioFechamento = consultorio.HorarioFechamento,
                                    CEP = consultorio.Localidade.CEP,
                                    Endereco = consultorio.Localidade.Endereco,
                                    Numero = consultorio.Localidade.Numero,
                                    Complemento = consultorio.Localidade.Complemento,
                                    Bairro = consultorio.Localidade.Bairro,
                                    Cidade = consultorio.Localidade.Cidade,
                                    Estado = consultorio.Localidade.Estado
                                };

                        break;
                    }

                case "EXAME":
                    {
                        query = from consultorio in db.TB_Consultorio
                                join consex in db.TB_ConsultorioExame on consultorio.IdConsultorio equals consex.IdConsultorio
                                join exame in db.TB_Exame on consex.IdExame equals exame.IdExame

                                where exame.Nome.ToString().Contains(pesquisa) //consultorio.Localidade.Cidade.ToString().Contains(pesquisa)
                                orderby consultorio.NomeFantasia ascending
                                select new ConsultaConsultorio
                                {
                                    IdConsultorio = consultorio.IdConsultorio,
                                    NomeFantasia = consultorio.NomeFantasia,
                                    RazaoSocial = consultorio.RazaoSocial,
                                    CNPJ = consultorio.CNPJ,
                                    Telefone = consultorio.Telefone,
                                    HorarioAbertura = consultorio.HorarioAbertura,
                                    HorarioFechamento = consultorio.HorarioFechamento,
                                    CEP = consultorio.Localidade.CEP,
                                    Endereco = consultorio.Localidade.Endereco,
                                    Numero = consultorio.Localidade.Numero,
                                    Complemento = consultorio.Localidade.Complemento,
                                    Bairro = consultorio.Localidade.Bairro,
                                    Cidade = consultorio.Localidade.Cidade,
                                    Estado = consultorio.Localidade.Estado
                                };

                        break;
                    }


            }

            var resultado = query.ToList();
            return resultado;
        }       

        public List<Funcionario> FindMedico(int idConsultorio)
        {
            var query = from qf in db.TB_QuadroFuncionarios
                        where qf.IdConsultorio == idConsultorio
                        where qf.Status == true
                        where qf.Funcionario.Funcao.Nome.Equals("Médico")
                        select qf.Funcionario;

            var resultado = query.ToList();

            return resultado;
        }

        public List<string> Update(Consultorio consultorio, Localidade localidade)
        {
            var errosConsultorio = Validacao.Validar(consultorio);
            var errosLocalidade = Validacao.Validar(localidade);

            try
            {
                if (errosConsultorio.Count() == 0 && errosLocalidade.Count() == 0)
                {
                    db.Set<Consultorio>().AddOrUpdate(consultorio);
                    db.Set<Localidade>().AddOrUpdate(localidade);
                    db.SaveChanges();
                    return null;
                }
                else
                {
                    List<string> listaErros = new List<string>();

                    foreach (var erro in errosConsultorio)
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
                throw new Exception("Não foi possível alterar o consultório!\n" + ex.ToString());
            }
        }
        public bool Delete(Consultorio consultorio)
        {
            try
            {
                consultorio = db.TB_Consultorio.Find(consultorio.IdConsultorio);
                db.TB_Consultorio.Remove(consultorio);
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
                throw new Exception("Não foi possível excluir este consultório pois ele está vinculado a um exame.");
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir este consultório!\n" + ex.Message);
            }
        }
        public Localidade FindLocalidade(int codigo)
        {
            Localidade l = db.TB_Consultorio.Find(codigo).Localidade;
            return l;
        }
    }


}
