using System;

namespace ClinicaMedica.Model
{
    internal class ConsultaConsulta
    {
        public int Codigo { get; set; }
        public TimeSpan Inicio { get; set; }
        public TimeSpan Final { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public bool Comparecimento { get; set; }
    }
}