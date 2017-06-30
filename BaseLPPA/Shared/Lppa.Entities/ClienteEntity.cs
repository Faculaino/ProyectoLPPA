using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class ClienteEntity : EntityBase
    {
        
        public string Nombre { get; set; }
        public String Apellido { get; set; }
        public long DNI { get; set; }
        public String Domicilio { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Ingreso { get; set; }
        public String Sexo { get; set; }
        public String Ocupacion { get; set; }
        public int CodEstado { get; set; }
        



    }
}
