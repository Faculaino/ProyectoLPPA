using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class BancoEntity : EntityBase
    {
        public int CodBanco { get; set; }
        public String RazonSocial { get; set; }
        public long CUIT { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Alias { get; set; }
    
    }
}
