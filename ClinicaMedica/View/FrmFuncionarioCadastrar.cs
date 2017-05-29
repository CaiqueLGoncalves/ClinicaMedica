using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmFuncionarioCadastrar : Form
    {
        public FrmFuncionarioCadastrar()
        {
            InitializeComponent();
        }

        private void FrmFuncionarioCadastrar_Activated(object sender, EventArgs e)
        {
            tB_FuncaoTableAdapter.Fill(clinicaMedicaBDDataSet.TB_Funcao);

            if (cmbFuncao.SelectedIndex != 0)
            {
                txbCRM.Clear();
                txbCRM.ReadOnly = true;
            }
        }

        private void cmbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFuncao.SelectedIndex != 0)
            {
                txbCRM.Clear();
                txbCRM.ReadOnly = true;
            }
            else
            {
                txbCRM.ReadOnly = false;
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
                cmbEstado.SelectedIndex = RetornarIndiceEstado(resposta.uf);
                cmbEstado.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o CEP informado!");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Localidade l = new Localidade();

            l.CEP = mskCEP.Text;
            l.Endereco = txbEndereco.Text;
            l.Numero = txbNumero.Text;
            l.Complemento = txbComplemento.Text;
            l.Bairro = txbBairro.Text;
            l.Cidade = txbCidade.Text;
            l.Estado = RetornarSiglaEstado(cmbEstado.SelectedIndex);

            if (cmbFuncao.SelectedIndex == 0)
            {
                MedicoController medicoCont = new MedicoController();
                Medico m = new Medico();

                m.Nome = txbNome.Text;
                m.CPF = mskCPF.Text;
                m.RG = txbRG.Text;
                m.DataNascimento = dtpDataNascimento.Value;
                m.IdFuncao = int.Parse(cmbFuncao.SelectedValue.ToString());
                m.CRM = txbCRM.Text;
                m.Email = txbEmail.Text;
                m.Localidade = l;

                // medicoCont.Insert(m);
            }
            else
            {
                FuncionarioController funcCont = new FuncionarioController();
                Funcionario f = new Funcionario();

                f.Nome = txbNome.Text;
                f.CPF = mskCPF.Text;
                f.RG = txbRG.Text;
                f.DataNascimento = dtpDataNascimento.Value;
                f.IdFuncao = int.Parse(cmbFuncao.SelectedValue.ToString());
                f.Email = txbEmail.Text;
                f.Localidade = l;

                // funcCont.Insert(f);
            }

            Controls.Clear();
        }

        private int RetornarIndiceEstado(string uf)
        {
            uf = uf.ToUpper();

            switch (uf)
            {
                case "AC": return 0;
                case "AL": return 1;
                case "AP": return 2;
                case "AM": return 3;
                case "BA": return 4;
                case "CE": return 5;
                case "DF": return 6;
                case "ES": return 7;
                case "GO": return 8;
                case "MA": return 9;
                case "MT": return 10;
                case "MS": return 11;
                case "MG": return 12;
                case "PA": return 13;
                case "PB": return 14;
                case "PR": return 15;
                case "PE": return 16;
                case "PI": return 17;
                case "RJ": return 18;
                case "RN": return 19;
                case "RS": return 20;
                case "RO": return 21;
                case "RR": return 22;
                case "SC": return 23;
                case "SP": return 24;
                case "SE": return 25;
                case "TO": return 26;
                default: throw new ArgumentException("UF Inexistente!");
            }
        }

        private string RetornarSiglaEstado(int indice)
        {
            switch (indice)
            {
                case 0: return "AC";
                case 1: return "AL";
                case 2: return "AP";
                case 3: return "AM";
                case 4: return "BA";
                case 5: return "CE";
                case 6: return "DF";
                case 7: return "ES";
                case 8: return "GO";
                case 9: return "MA";
                case 10: return "MT";
                case 11: return "MS";
                case 12: return "MG";
                case 13: return "PA";
                case 14: return "PB";
                case 15: return "PR";
                case 16: return "PE";
                case 17: return "PI";
                case 18: return "RJ";
                case 19: return "RN";
                case 20: return "RS";
                case 21: return "RO";
                case 22: return "RR";
                case 23: return "SC";
                case 24: return "SP";
                case 25: return "SE";
                case 26: return "TO";
                default: throw new ArgumentException("UF Inexistente!");
            }
        }
    }
}
