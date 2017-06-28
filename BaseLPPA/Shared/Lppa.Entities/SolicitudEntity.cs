using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class SolicitudEntity : EntityBase
    {
        public int CodSolicitud { get; set; }
        public DateTime FechaEmision { get; set; }
        public int CodTarjeta { get; set; }
        public int CodCliente { get; set; }
        
    }
}
