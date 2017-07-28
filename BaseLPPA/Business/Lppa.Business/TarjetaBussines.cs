using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;
using Lppa.Data;

namespace Lppa.Business
{
    public class TarjetaBussines
    {
        public void insert(TarjetaEntity tarjeta, long dni)
        {
            var tr = new TarjetaRepository();
            tr.insert(tarjeta,dni);
        }
    }
}
