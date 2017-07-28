using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class TarjetaEntity : EntityBase
    {
        //public int CodTarjeta { get; set; }
        public int IDBanco { get; set; }
        public int IDCliente { get; set; }
        //public string NombreTitular { get; set; }
        //public int Ejemplar { get; set; }
        public String Marca { get; set; }
        public DateTime FechaEmision { get; set; }
        //public DateTime FechaBaja { get; set; }
        public DateTime FechaVencimiento { get; set; }
        //public int AñoVencimiento { get; set; }
        public int CodVerificacion { get; set; }
        public int Limite { get; set; }
        public int CodEstado { get; set; }
        
    }
}

