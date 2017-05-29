using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicaMedica.Model
{
    class Validacao
    {
        public static IEnumerable<ValidationResult> ValidaConsultorio(Object objeto)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(objeto, null, null);

            Validator.TryValidateObject(objeto, contexto, erros, true);
            return erros;
        }

        public static IEnumerable<ValidationResult> ValidaPaciente(Object objeto)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(objeto, null, null);

            Validator.TryValidateObject(objeto, contexto, erros, true);
            return erros;
        }

        public static IEnumerable<ValidationResult> ValidaEstoque(Object objeto)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(objeto, null, null);

            Validator.TryValidateObject(objeto, contexto, erros, true);
            return erros;
        }

        public static IEnumerable<ValidationResult> ValidaProduto(Object objeto)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(objeto, null, null);

            Validator.TryValidateObject(objeto, contexto, erros, true);
            return erros;
        }

        public static IEnumerable<ValidationResult> ValidaExame(Object objeto)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(objeto, null, null);

            Validator.TryValidateObject(objeto, contexto, erros, true);
            return erros;
        }

        public static IEnumerable<ValidationResult> ValidaExameConsultorio(Object objeto)
        {
            var erros = new List<ValidationResult>();
            var contexto = new ValidationContext(objeto, null, null);

            Validator.TryValidateObject(objeto, contexto, erros, true);
            return erros;
        }
    }
}