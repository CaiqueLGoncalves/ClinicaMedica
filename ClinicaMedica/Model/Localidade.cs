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

    public partial class Localidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Localidade()
        {
            Pessoa = new HashSet<Usuario>();
        }
    
        public int IdLocalidade { get; set; }
        [Required(ErrorMessage = "O campo 'Endere�o' � obrigat�rio!", AllowEmptyStrings = false)]
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo 'Cidade' � obrigat�rio!", AllowEmptyStrings = false)]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O campo 'Estado' � obrigat�rio!", AllowEmptyStrings = false)]
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Pessoa { get; set; }
        public virtual Consultorio Consultorio { get; set; }
    }
}
