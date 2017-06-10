using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
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
    }
}
