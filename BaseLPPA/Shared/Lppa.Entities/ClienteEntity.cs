using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    public class ClienteEntity : EntityBase
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public String Apellido { get; set; }
        [Required]
        public long DNI { get; set; }
        [Required]
        public String Domicilio { get; set; }
        [Required]
        public string EstadoCivil { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public decimal Ingreso { get; set; }
        [Required]
        public String Sexo { get; set; }
        [Required]
        public String Ocupacion { get; set; }
        [Required]
        public int CodEstado { get; set; }
        



    }
}
