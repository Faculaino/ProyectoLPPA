using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class SistemaBancarioEntity : EntityBase
    {
        public long NroDoc { get; set; }
        public String Banco { get; set; }
        public String Observaciones { get; set; }

    }
}
