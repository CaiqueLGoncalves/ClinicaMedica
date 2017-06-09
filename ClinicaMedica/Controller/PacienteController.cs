﻿using ClinicaMedica.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace ClinicaMedica.Controller
{
    class PacienteController
    {
        private DataModelContainer db = new DataModelContainer();

        public List<string> Insert(Paciente paciente)
        {
            var erros = Validacao.Validar(paciente);

            try
            {
                if (erros.Count() == 0)
                {
                    db.TB_Usuario.Add(paciente);
                    db.SaveChanges();
                    return null;
                }
                else
                {
                    List<string> listaErros = new List<string>();

                    foreach (var erro in erros)
                    {
                        listaErros.Add(erro.ErrorMessage);
                    }

                    return listaErros;
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var evError in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" possui os seguintes erros de validação: ",
                                       evError.Entry.Entity.GetType().Name,
                                       evError.Entry.State);

                    foreach (var valError in evError.ValidationErrors)
                    {
                        Console.WriteLine("- Propriedade: \"{0}\", Valor: \"{1}\", Erro: \"{2}\"",
                                          valError.PropertyName,
                                          evError.Entry.CurrentValues.GetValue<object>(valError.PropertyName),
                                          valError.ErrorMessage);
                    }
                }

                throw new Exception("Erro Interno. Por favor, contate o(s) administrador(es) do sistema.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível cadastrar o paciente!\n" + ex.Message);
            }
        }

        public List<ConsultaPaciente> Select()
        {
            var query = from paciente in db.TB_Usuario_Paciente
                        orderby paciente.Identificacao ascending
                        select new ConsultaPaciente
                        {
                            Codigo = paciente.Identificacao,
                            Nome = paciente.Nome,
                            CPF = paciente.CPF,
                            RG = paciente.RG,
                            DataNascimento = paciente.DataNascimento,
                            Sexo = paciente.Sexo,
                            TelefoneResidencial = paciente.TelefoneResidencial,
                            TelefoneComercial = paciente.TelefoneComercial,
                            TelefoneCelular = paciente.TelefoneCelular,
                            Email = paciente.Email,
                            CEP = paciente.Localidade.CEP,
                            Endereco = paciente.Localidade.Endereco,
                            Numero = paciente.Localidade.Numero,
                            Complemento = paciente.Localidade.Complemento,
                            Bairro = paciente.Localidade.Bairro,
                            Cidade = paciente.Localidade.Cidade,
                            Estado = paciente.Localidade.Estado
                        };

            var resultado = query.ToList();
            return resultado;           
        }
    }
}