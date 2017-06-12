using System;

namespace ClinicaMedica.Model
{
    internal class ConsultaQuadroFuncionarios
    {
        public string Consultorio { get; set; }
        public string Funcionario { get; set; }
        public string FuncFuncao { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; internal set; }
        public bool Status { get; set; }
        public int IdConsultorio { get; set; }
        public int IdFuncionario { get; set; }
    }
}