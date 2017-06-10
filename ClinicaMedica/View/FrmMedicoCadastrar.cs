using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmMedicoCadastrar : Form
    {
        public FrmMedicoCadastrar()
        {
            InitializeComponent();
        }

        private void FrmMedicoCadastrar_Load(object sender, EventArgs e)
        {
            // Carregar o DataGridView
            TB_EspecialidadeTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Especialidade);

            // Deseleciona todas as especialidades
            for (int i = 0; i < dgvEspecialidades.Rows.Count; i++)
            {
                dgvEspecialidades.Rows[i].Selected = false;
            }
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(mskCEP.Text);

                txbEndereco.Text = resposta.end;
                txbEndereco.ReadOnly = true;
                txbBairro.Text = resposta.bairro;
                txbBairro.ReadOnly = true;
                txbCidade.Text = resposta.cidade;
                txbCidade.ReadOnly = true;
                cmbEstado.SelectedIndex = Utilitario.RetornarIndiceEstado(resposta.uf);
                cmbEstado.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoController medicoCont = new MedicoController();
                Medico m = new Medico();

                /* Lista de Especialidades do Médico */

                List<int> listaIdEspecialidade = new List<int>();

                for (int i = 0; i < dgvEspecialidades.SelectedRows.Count; i++)
                {
                    listaIdEspecialidade.Add(int.Parse(dgvEspecialidades.SelectedRows[i].Cells["IdEspecialidade"].Value.ToString()));
                }

                listaIdEspecialidade.Sort();

                /* Localidade do Médico */

                Localidade l = new Localidade();

                l.CEP = mskCEP.Text;
                l.Endereco = txbEndereco.Text;
                l.Numero = txbNumero.Text;
                l.Complemento = txbComplemento.Text;
                l.Bairro = txbBairro.Text;
                l.Cidade = txbCidade.Text;
                l.Estado = Utilitario.RetornarSiglaEstado(cmbEstado.SelectedIndex);

                /* Cadastro do Médico */

                m.Nome = txbNome.Text;
                m.CPF = mskCPF.Text;
                m.RG = txbRG.Text;
                m.DataNascimento = dtpDataNascimento.Value;
                m.Sexo = (rbtMasculino.Checked) ? rbtMasculino.Text : rbtFeminino.Text;

                m.IdFuncao = 1;
                m.CRM = txbCRM.Text;

                m.TelefoneResidencial = mskTelefoneResidencial.Text;
                m.TelefoneComercial = mskTelefoneComercial.Text;
                m.TelefoneCelular = mskTelefoneCelular.Text;
                m.Email = txbEmail.Text;

                m.Localidade = l;

                var resultado = medicoCont.Insert(m);

                if (resultado == null)
                {
                    MedicoEspecialidadeController meCont = new MedicoEspecialidadeController();
                    int numeroErros = 0;

                    foreach (var IdEsp in listaIdEspecialidade)
                    {
                        MedicoEspecialidade me = new MedicoEspecialidade();
                        me.IdentificacaoMedico = m.Identificacao;
                        me.IdEspecialidade = IdEsp;

                        numeroErros += meCont.Insert(me);
                    }

                    if (numeroErros == 0)
                    {
                        MessageBox.Show("Médico cadastrado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Médico cadastrado, porém com erros.", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível cadastrar o médico!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}