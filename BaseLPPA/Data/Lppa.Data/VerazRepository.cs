using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;

namespace Lppa.Data
{
    public class VerazRepository
    {
        Model db = new Model();

         public int ValidarVeraz(long NroDoc)
        {
            // 1 = Cliente sin antecedentes negativos en el sistema financiero.Sigue adelante el proceso.
            // 3 = Cliente “dudoso”. La decisión de otorgar o no la tarjeta dependerá de otros factores.

            if (db.TablaVeraz.Find(NroDoc) == null)
                return 1;
            else return 3;
        }
    }
}
