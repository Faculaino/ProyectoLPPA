using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class Solicitud : EntityBase
    {
        public DateTime Fecha { get; set; }
        public Usuario Cliente { get; set; }

    }
}
