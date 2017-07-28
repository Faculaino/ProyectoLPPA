using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class SolicitudEntity : EntityBase
    {
        public int CodEstado { get; set; }
        public int IDTarjeta { get; set; }
        public int IDCliente { get; set; }
        
        
    }
}
