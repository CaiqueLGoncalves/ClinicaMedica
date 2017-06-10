using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncaoManter : Form
    {
        private int idFuncao;

        public FrmFuncaoManter(int idFuncao, string nome, string descricao)
        {
            InitializeComponent();

            // ID da Função
            this.idFuncao = idFuncao;

            // Nome da Função
            txbNome.Text = nome;

            // Descrição da Função
            txbDescricao.Text = descricao;
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            try
            {
                FuncaoController funcCont = new FuncaoController();
                Funcao funcao = new Funcao();
                funcao.IdFuncao = idFuncao;

                if (funcCont.Delete(funcao))
                {
                    MessageBox.Show("Função excluída com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}