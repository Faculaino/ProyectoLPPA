using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;
using Lppa.Business;

namespace Lppa.UI.Process
{
    public class TarjetaComponentController
    {
        public void insert(TarjetaEntity tarjeta, long dni)
        {
            var tb = new TarjetaBussines();
            tb.insert(tarjeta, dni);
        }
    }
}
