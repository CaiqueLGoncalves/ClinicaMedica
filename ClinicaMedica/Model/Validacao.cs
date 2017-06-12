using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicaMedica.Model
{
    class Validacao
    {
        public static IEnumerable<ValidationResult> Validar(object objeto)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(objeto, null, null);

            Validator.TryValidateObject(objeto, contexto, erros, true);
            return erros;
        }

        public static IEnumerable<ValidationResult> ValidarConsultorio(Consultorio consultorio)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(consultorio, null, null);
            if (!IsCnpj(consultorio.CNPJ.ToString()))
                erros.Add(new ValidationResult("CNPJ inválido"));
            Validator.TryValidateObject(consultorio, contexto, erros, true);
            return erros;
        }

        public static IEnumerable<ValidationResult> ValidarUsuario(Usuario usuario)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(usuario, null, null);

            if (!IsCpf(usuario.CPF.ToString()))
            {
                erros.Add(new ValidationResult("CPF Inválido!"));
            }

            Validator.TryValidateObject(usuario, contexto, erros, true);
            return erros;
        }

        //true valido false invalido
        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }



    }
}