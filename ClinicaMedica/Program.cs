using ClinicaMedica.View;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaMedica
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmIndex());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de Rede. Por favor, tente novamente.\nMensagem de Erro: " + ex.Message, "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensagem de Erro: " + ex.Message, "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
