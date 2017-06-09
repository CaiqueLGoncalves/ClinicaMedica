using System;

namespace ClinicaMedica.Model
{
    internal class ConsultaPaciente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}