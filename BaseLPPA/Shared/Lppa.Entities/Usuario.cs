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
        public Usuario()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cuil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Dni { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Domicilio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EstadoCivil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double IngresoMensual { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nacionalidad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sexo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SituacionLaboral { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Apellido { get; set; }
    }
}
