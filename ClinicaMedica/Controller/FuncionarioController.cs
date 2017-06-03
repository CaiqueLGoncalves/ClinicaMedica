using ClinicaMedica.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaMedica.Controller
{
    class FuncionarioController
    {
        private DataModelContainer db = new DataModelContainer();

        public void Insert(Funcionario funcionario)
        {
            var erros = Validacao.Validar(funcionario);

            if (erros.Count() == 0)
            {
                try
                {
                    db.TB_Usuario.Add(funcionario);
                    db.SaveChanges();
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                }
                /*
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                */
                catch (Exception e)
                {
                    MessageBox.Show("Não foi possível cadastrar o funcionário!\n" + e.Message);
                }

                Form.ActiveForm.Close();
            }
            else
            {
                foreach (var e in erros)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
    }
}