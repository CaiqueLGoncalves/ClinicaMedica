//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicaMedica.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Consultorio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Consultorio()
        {
            QuadroFuncionarios = new HashSet<QuadroFuncionarios>();
            Consulta = new HashSet<Consulta>();
            AgendaExame = new HashSet<AgendaExame>();
            ConsultorioExame = new HashSet<ConsultorioExame>();
        }
    
        public int IdConsultorio { get; set; }

        [Required(ErrorMessage = "Nome Fantasia � obrigat�rio!", AllowEmptyStrings = false)]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Raz�o Social � obrigat�ria!", AllowEmptyStrings = false)]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "CNPJ � obrigat�rio!!!", AllowEmptyStrings = false)]
        public string CNPJ { get; set; }
        public System.TimeSpan HorarioAbertura { get; set; }
        public System.TimeSpan HorarioFechamento { get; set; }
        public string Telefone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuadroFuncionarios> QuadroFuncionarios { get; set; }
        public virtual Localidade Localidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> Consulta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgendaExame> AgendaExame { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultorioExame> ConsultorioExame { get; set; }
    }
}
