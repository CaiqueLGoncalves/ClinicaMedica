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

    public partial class Exame
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exame()
        {
            AgendaExame = new HashSet<AgendaExame>();
            ConsultorioExame = new HashSet<ConsultorioExame>();
        }
    
        public int IdExame { get; set; }
        [Required(ErrorMessage = "Nome do Exame � obrigat�rio!", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public string Recomendacoes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgendaExame> AgendaExame { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultorioExame> ConsultorioExame { get; set; }
    }
}
