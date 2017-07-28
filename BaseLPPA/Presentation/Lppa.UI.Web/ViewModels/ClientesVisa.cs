using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lppa.UI.Web.ViewModels
{
    public class ClientesVisa
    {
        public string Nombre { get; set; }
        public string MarcaTarjeta { get; set; }
        public DateTime FechaEmision { get; set; }
        public int FechaVencimiento { get; set; }
        public int Limite { get; set; }
    }
}