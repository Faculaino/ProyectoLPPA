using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Data;

namespace Lppa.Business
{
    public class VerazBussines
    {
        public string Validar(long dni)
        {
            var vr = new VerazRepository();
            return vr.ValidarVeraz(dni);
            
        }


       

    }
}
