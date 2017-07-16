using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Lppa.UI.Web.ViewModels
{
    public class ContratoViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Introduzca un email válido")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "El email no puede tener mas de 50 caracteres")]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "El telefono no puede tener mas de 30 caracteres")]
        public string Telefono { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "El celular no puede tener mas de 30 caracteres")]
        public string Celular { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase Imagen { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase FirmaElectronica { get; set; }
    }
}