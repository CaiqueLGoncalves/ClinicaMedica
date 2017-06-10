using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Model
{
    class ConsultaConsultorio
    {
        public int IdConsultorio { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public System.TimeSpan HorarioAbertura { get; set; }
        public System.TimeSpan HorarioFechamento { get; set; }
     //   public string Telefone { get; set; }
    }
}
