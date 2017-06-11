using ClinicaMedica.Model;
using ClinicaMedica.View;
using System;
using System.Collections.Generic;
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
    }


}
