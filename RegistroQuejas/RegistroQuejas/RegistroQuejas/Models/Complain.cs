using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroQuejas.Models
{
    public class Complain
    {
        [Key]
        public int QuejaId { get; set; }
        [Required(ErrorMessage = "La fecha es obligatorio")]
        [Display(Name = "Fecha:")]

        public string QuejaFecha { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre:")]
        [StringLength(50,ErrorMessage ="No debe tener mas de 50 caracteres.")]
        [MinLength(3, ErrorMessage ="Debe tener mas de 3 caracteres.")]
        public string QuejaNombre { get; set; }
        [Display(Name = "Identidad:")]

        public string QuejaDni { get; set; }
        [Display(Name = "C.C.:")]
        [StringLength(50, ErrorMessage = "No debe tener mas de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de 3 caracteres.")]

        public string QuejaCopia { get; set; }
        [Display(Name = "Número:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int QuejaNum { get; set; }
        [Display(Name = "Dependencia:")]
        [StringLength(50, ErrorMessage = "No debe tener mas de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de 3 caracteres.")]

        public string QuejaDependencia { get; set; }
        [Display(Name = "Cargo:")]
        [StringLength(50, ErrorMessage = "No debe tener mas de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de 3 caracteres.")]

        public string QuejaCargo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Correo Electrónico:")]
        
        //[DataType(DataType.EmailAddress, ErrorMessage = "Por favor, ingrese un email válido")]
        [EmailAddress(ErrorMessage = "Por favor, ingrese un email válido")]
        public string QuejaEmail { get; set; }
        [Display(Name = "QUEJAS")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string QuejaQueja { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string QuejaHechos { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string QuejaPrueba { get; set; }
    }
}
