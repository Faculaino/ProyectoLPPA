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
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Celular { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase Imagen { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase FirmaElectronica { get; set; }
    }
}