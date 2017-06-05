using System;
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




    }
}