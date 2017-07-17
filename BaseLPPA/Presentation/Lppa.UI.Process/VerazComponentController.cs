using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Business;

namespace Lppa.UI.Process
{
    public class VerazComponentController
    {
        public string ValidarVeraz(long dni)
        {
            var vb = new VerazBussines();
            return vb.Validar(dni);

        }

    }
}
