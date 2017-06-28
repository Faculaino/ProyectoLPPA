using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class ClienteEntity : EntityBase
    {
        public int CodCliente { get; set; }
        public string Nombre { get; set; }
        public String Apellido { get; set; }
        public int TipoDoc { get; set; }
        public long NroDoc { get; set; }
        public String Domicilio { get; set; }
        public int EstadoCivil { get; set; }
        public decimal Ingreso { get; set; }
        public String Nacionalidad { get; set; }
        public String Sexo { get; set; }
        public String Ocupacion { get; set; }
        public int CodEstado { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }



    }
}
