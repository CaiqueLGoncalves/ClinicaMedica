﻿using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncionarioManter : Form
    {
        private int codigo;

        public FrmFuncionarioManter(int codigo, string nome, string cpf, string rg, DateTime dataNascimento, string sexo, string funcao, string telefoneResidencial, string telefoneComercial, string telefoneCelular, string email, string cep, string endereco, string numero, string complemento, string bairro, string cidade, string estado)
        {
            InitializeComponent();

            // Identificação do Funcionário
            this.codigo = codigo;

            // Nome Completo
            txbNome.Text = nome;

            // CPF 
            mskCPF.Text = cpf;

            // RG
            txbRG.Text = rg;

            // Data de Nascimento
            dtpDataNascimento.Value = dataNascimento;

            // Sexo
            if (sexo.Equals("Masculino"))
                rbtMasculino.Checked = true;
            else
                rbtFeminino.Checked = true;

            // Função
            cmbFuncao.SelectedItem = funcao;

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

        private void FrmFuncionarioManter_Load(object sender, EventArgs e)
        {
            TB_FuncaoTableAdapter.Fill(ClinicaMedicaBDDataSet.TB_Funcao);
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
                FuncionarioController funcCont = new FuncionarioController();
                Funcionario f = new Funcionario();
                Localidade l = new Localidade();

                l.IdLocalidade = funcCont.FindLocalidade(codigo).IdLocalidade;
                l.CEP = mskCEP.Text;
                l.Endereco = txbEndereco.Text;
                l.Numero = txbNumero.Text;
                l.Complemento = txbComplemento.Text;
                l.Bairro = txbBairro.Text;
                l.Cidade = txbCidade.Text;
                l.Estado = Utilitario.RetornarSiglaEstado(cmbEstado.SelectedIndex);

                f.Identificacao = codigo;
                f.Nome = txbNome.Text;
                f.CPF = mskCPF.Text;
                f.RG = txbRG.Text;
                f.DataNascimento = dtpDataNascimento.Value;
                f.Sexo = (rbtMasculino.Checked) ? rbtMasculino.Text : rbtFeminino.Text;
                f.TelefoneResidencial = mskTelefoneResidencial.Text;
                f.TelefoneComercial = mskTelefoneResidencial.Text;
                f.TelefoneCelular = mskTelefoneCelular.Text;
                f.IdFuncao = int.Parse(cmbFuncao.SelectedValue.ToString());
                f.Email = txbEmail.Text;
                f.IdLocalidade = l.IdLocalidade;
                f.Localidade = l;

                var resultado = funcCont.Update(f, l);

                if (resultado == null)
                {
                    MessageBox.Show("Funcionário alterado com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    foreach (var erro in resultado)
                    {
                        MessageBox.Show("Não foi possível alterar o funcionário!\n" + erro, "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                FuncionarioController funcCont = new FuncionarioController();
                Funcionario func = new Funcionario();
                func.Identificacao = codigo;

                if (funcCont.Delete(func))
                {
                    MessageBox.Show("Funcionário excluído com sucesso!", "Clinica Médica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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