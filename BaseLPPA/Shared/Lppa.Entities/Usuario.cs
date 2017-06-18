using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Usuario : EntityBase
    {
        public string CUIL { get; set; }
        
        public string DNI { get; set; }
       
        public string Domicilio { get; set; }
        
        public string EstadoCivil { get; set; }
        
        public DateTime FechaNacimiento { get; set; }
       
        public double Ingreso { get; set; }
        
        public string Nacionalidad { get; set; }
        
        public string Sexo { get; set; }
        
        public string SituacionLaboral { get; set; }
        
        public string Nombre { get; set; }
       
        public string Apellido { get; set; }

        public void Select()
        {
           
        }
    }
}
