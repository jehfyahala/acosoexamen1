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
        [Display(Name = "Fecha:")]

        public string QuejaFecha { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre:")]
        public string QuejaNombre { get; set; }
        [Display(Name = "Identidad:")]

        public string QuejaDni { get; set; }
        [Display(Name = "C.C.:")]

        public string QuejaCopia { get; set; }
        [Display(Name = "Número:")]

        public int QuejaNum { get; set; }
        [Display(Name = "Dependencia:")]

        public string QuejaDependencia { get; set; }
        [Display(Name = "Cargo:")]

        public string QuejaCargo { get; set; }
        [Display(Name = "Correo Electrónico:")]

        public string QuejaEmail { get; set; }
        [Display(Name = "QUEJAS")]

        public string QuejaQueja { get; set; }
        public string QuejaHechos { get; set; }

        public string QuejaPrueba { get; set; }
    }
}
