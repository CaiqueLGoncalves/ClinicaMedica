using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.Controller
{
    class ConsultorioExameController
    {
        private DataModelContainer db = new DataModelContainer();

        public void Insert(ConsultorioExame conex)
        {

            var erros = Validacao.Validar(conex);


            if (erros.Count() == 0)
            {
                try
                {
                    db.TB_ConsultorioExame.Add(conex);
                    db.SaveChanges();
                  //  MessageBox.Show("Especialidades adicionadas ao consultório!");
                }

                catch (Exception e)
                {
                   MessageBox.Show("Não foi possível cadastrar as especialidades no consultório!\n" + e.Message);
                }
                //  CadastroCargo.ActiveForm.Close();

            }
            else
            {
                foreach (var e in erros)
                    MessageBox.Show(e.ToString());
            }

        }

        public List<int> Select(int idconsultorio)
        {
            var query = from consultorio in db.TB_ConsultorioExame
                        where consultorio.IdConsultorio == idconsultorio
                        orderby consultorio.IdExame ascending
                        select consultorio.IdExame;

            var resultado = query.ToList();

            return resultado;
        }

        public bool Delete(ConsultorioExame consultorioExame)
        {
            try
            {
                consultorioExame = db.TB_ConsultorioExame.Find(consultorioExame.IdExame, consultorioExame.IdConsultorio);
                db.TB_ConsultorioExame.Remove(consultorioExame);
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
                throw new Exception("Não foi possível excluir este relacionamento entre consultório e exame!\n" + ex.Message);
            }
        }



    }
}
