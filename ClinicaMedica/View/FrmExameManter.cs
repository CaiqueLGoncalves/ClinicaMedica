using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmExameManter : Form
    {
        private int idexame;
        public FrmExameManter(int idexame, string nome, string recomendacoes)
        {
            InitializeComponent();

            this.idexame = idexame;
            txbNome.Text = nome;
            txbRecomendacoes.Text = recomendacoes;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ExameController exameCont = new ExameController();
                Exame ex = new Exame();

                ex.IdExame = idexame;
                ex.Nome = txbNome.Text;
                ex.Recomendacoes = txbRecomendacoes.Text;

                var resultado = exameCont.Update(ex);

                if (resultado == null)
                {
                    MessageBox.Show("Exame alterado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível alterar o exame!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ExameController exCont = new ExameController();
                Exame exame = new Exame();
                exame.IdExame = idexame;

                if (exCont.Delete(exame))
                {
                    MessageBox.Show("Exame excluído com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmExameManter_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
