using ClinicaMedica.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaMedica.Controller
{
    class PacienteController
    {
        private DataModelContainer db = new DataModelContainer();

        public void Insert(Paciente paciente)
        {
            var erros = Validacao.Validar(paciente);

            if (erros.Count() == 0)
            {
                try
                {
                    db.TB_Usuario.Add(paciente);
                    db.SaveChanges();
                    MessageBox.Show("Paciente cadastrado com sucesso!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não foi possível cadastrar o paciente!\n" + e.Message);
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