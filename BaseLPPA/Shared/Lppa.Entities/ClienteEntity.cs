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
        public string Apellido { get; set; }
        public int TipoDoc { get; set; }
        public long NroDoc { get; set; }
        public string Domicilio { get; set; }
        public int EstadoCivil { get; set; }
        public decimal Ingreso { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public string Ocupacion { get; set; }
        public int CodEstado { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }



    }
}
