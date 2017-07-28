using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lppa.UI.Web.ViewModels
{
    public class BancoViewModel
    {

        [Required]
        public int CodBanco { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "La Razon Social no puede tener mas de 50 caracteres")]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El Alias no puede tener mas de 50 caracteres")]
        public string Alias { get; set; }

        [Required]
        public long CUIT { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La Direccion no puede tener mas de 10 caracteres")]
        public string Direccion { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El Telefono no puede tener mas de 20 caracteres")]
        public string Telefono { get; set; }

   }
}