using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lppa.UI.Web.ViewModels
{
    public class ClienteViewModel
    {
        [Required]
        public int DNI { get; set; }
        [Required]
        public int TipoDoc { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El Nombre no puede tener mas de 50 caracteres")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El Apellido no puede tener mas de 50 caracteres")]
        public string Apellido { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "El CUIL no puede tener mas de 11 caracteres")]
        public string CUIL { get; set; }

        [Required]
        public string Ocupacion { get; set; }
    }
}