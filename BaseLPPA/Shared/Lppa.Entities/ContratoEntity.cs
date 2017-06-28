using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class ContratoEntity : EntityBase
    {
        public int CodContrato { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public int CodTarjeta { get; set; }
        public int CodCliente { get; set; }
        public int CodUsr { get; set; }
        public int CodEstado { get; set; }

    }
}

