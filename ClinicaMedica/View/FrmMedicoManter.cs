using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmMedicoManter : Form
    {
        private int codigo;

        public FrmMedicoManter(int codigo, string nome, string cpf, string rg, string crm, DateTime dataNascimento, string sexo, string telefoneResidencial, string telefoneComercial, string telefoneCelular, string email, string cep, string endereco, string numero, string complemento, string bairro, string cidade, string estado)
        {
            InitializeComponent();

            // Identificação do Paciente
            this.codigo = codigo;

            // Nome Completo
            txbNome.Text = nome;

            // CPF 
            mskCPF.Text = cpf;

            // RG
            txbRG.Text = rg;

            // CRM
            txbCRM.Text = crm;

            // Data de Nascimento
            dtpDataNascimento.Value = dataNascimento;

            // Sexo
            if (sexo.Equals("Masculino"))
                rbtMasculino.Checked = true;
            else
                rbtFeminino.Checked = true;

            // Telefone Residencial
            mskTelefoneResidencial.Text = telefoneResidencial;

            // Telefone Comercial
            mskTelefoneComercial.Text = telefoneComercial;

            // Telefone Celular
            mskTelefoneCelular.Text = telefoneCelular;

            // E-mail
            txbEmail.Text = email;

            // CEP
            mskCEP.Text = cep;

            // Endereço
            txbEndereco.Text = endereco;

            // Número da Casa
            txbNumero.Text = numero;

            // Complemento
            txbComplemento.Text = complemento;

            // Bairro
            txbBairro.Text = bairro;

            // Cidade
            txbCidade.Text = cidade;

            // Estado
            cmbEstado.SelectedIndex = Utilitario.RetornarIndiceEstado(estado);
        }

        private void FrmMedicoManter_Load(object sender, EventArgs e)
        {
            // Carrega o DataGridView
            TB_EspecialidadeTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Especialidade);

            // Deseleciona todas as especialidades
            for (int i = 0; i < dgvEspecialidades.Rows.Count; i++)
            {
                dgvEspecialidades.Rows[i].Selected = false;
            }

            // Seleciona apenas as especialidades atribuídas ao médico
            var especialidades = new MedicoEspecialidadeController().Select(codigo);

            foreach (int esp in especialidades)
            {
                for (int i = 0; i < dgvEspecialidades.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvEspecialidades.Rows[i].Cells["IdEspecialidade"].Value.ToString()) == esp)
                    {
                        dgvEspecialidades.Rows[i].Selected = true;
                    }
                }
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoController medicoCont = new MedicoController();
                MedicoEspecialidadeController meCont = new MedicoEspecialidadeController();

                /* Excluir Todas as Especialidades do Médico */

                List<int> especialidadesCadastradas = meCont.Select(codigo);

                foreach (var esp in especialidadesCadastradas)
                {
                    MedicoEspecialidade me = new MedicoEspecialidade();
                    me.IdentificacaoMedico = codigo;
                    me.IdEspecialidade = esp;
                
                    meCont.Delete(me);
                }

                /* Lista de Especialidades do Médico para Cadastrar */

                List<int> listaIdEspecialidade = new List<int>();

                for (int i = 0; i < dgvEspecialidades.SelectedRows.Count; i++)
                {
                    listaIdEspecialidade.Add(int.Parse(dgvEspecialidades.SelectedRows[i].Cells["IdEspecialidade"].Value.ToString()));
                }

                listaIdEspecialidade.Sort();

                /* Localidade do Médico */

                Localidade l = new Localidade();

                l.IdLocalidade = medicoCont.FindLocalidade(codigo).IdLocalidade;
                l.CEP = mskCEP.Text;
                l.Endereco = txbEndereco.Text;
                l.Numero = txbNumero.Text;
                l.Complemento = txbComplemento.Text;
                l.Bairro = txbBairro.Text;
                l.Cidade = txbCidade.Text;
                l.Estado = Utilitario.RetornarSiglaEstado(cmbEstado.SelectedIndex);

                /* Cadastro do Médico */

                Medico m = new Medico();

                m.Identificacao = codigo;
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

                m.IdLocalidade = l.IdLocalidade;
                m.Localidade = l;

                var resultado = medicoCont.Update(m, l);

                if (resultado == null)
                {
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
                        MessageBox.Show("Médico alterado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Médico alterado, porém com erros.", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível alterar o médico!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MedicoEspecialidadeController meCont = new MedicoEspecialidadeController();
                var especialidades = meCont.Select(codigo);
                int erros = 0;

                foreach (var esp in especialidades)
                {
                    MedicoEspecialidade me = new MedicoEspecialidade();
                    me.IdentificacaoMedico = codigo;
                    me.IdEspecialidade = esp;

                    if (!meCont.Delete(me))
                    {
                        erros++;
                    }
                }
                 
                if (erros == 0)
                {
                    MedicoController medicoCont = new MedicoController();
                    Medico medico = new Medico();
                    medico.Identificacao = codigo;

                    if (medicoCont.Delete(medico))
                    {
                        MessageBox.Show("Médico excluído com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkCEP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCEP.Checked)
            {
                txbEndereco.ReadOnly = false;
                txbNumero.ReadOnly = false;
                txbComplemento.ReadOnly = false;
                txbBairro.ReadOnly = false;
                txbCidade.ReadOnly = false;
                cmbEstado.Enabled = true;
            }
            else
            {
                txbEndereco.ReadOnly = true;
                txbBairro.ReadOnly = true;
                txbCidade.ReadOnly = true;
                cmbEstado.Enabled = false;
            }
        }
    }
}
