using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Model
{
    class ConsultaAgendaExame
    {
        public int IdAgendaExame { get; set; }
        public int IdentificacaoPaciente { get; set; }
        public int IdExame { get; set; }
        public int IdConsultorio { get; set; }
        public System.DateTime DataHoraInicio { get; set; }
        public System.DateTime DataHoraFim { get; set; }
        public string Paciente { get; set; }
        public string Exame { get; set; }
        public bool Comparecimento { get; set; }
        public string Anotacoes { get; set; }
    }
}
