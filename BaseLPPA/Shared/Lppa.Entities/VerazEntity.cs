using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class VerazEntity : EntityBase
    {
        public long NroDoc { get; set; }
        public DateTime FechaIngreso { get; set; }
        public String Observaciones { get; set; }

    }
}

