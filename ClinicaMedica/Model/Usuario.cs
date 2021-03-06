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
    using System.ComponentModel.DataAnnotations;

    public partial class Usuario
    {
        public int Identificacao { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' � obrigat�rio!", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        [Required(ErrorMessage = "O campo 'Data de Nascimento' � obrigat�rio!")]
        public System.DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "O campo 'Sexo' � obrigat�rio!", AllowEmptyStrings = false)]
        public string Sexo { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public int IdLocalidade { get; set; }
    
        public virtual Localidade Localidade { get; set; }
    }
}
