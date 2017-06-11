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

            if (nome.Equals("Médico"))
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncaoController funcaoCont = new FuncaoController();
                Funcao f = new Funcao();

                f.IdFuncao = idFuncao;
                f.Nome = txbNome.Text;
                f.Descricao = txbDescricao.Text;

                var resultado = funcaoCont.Update(f);

                if (resultado == null)
                {
                    MessageBox.Show("Função alterada com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível alterar a função!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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