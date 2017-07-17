using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Data
{
    public class VerazRepository
    {
        LppaBD db = new LppaBD();

        public string ValidarVeraz(long nroDoc)
        {
            var query = db.Veraz.Where(o => o.DNI == nroDoc).FirstOrDefault();
            string resultado = "";

            if (query == null)
            {
                return "Tarjeta de $7000";
            }
            else
            {

                TimeSpan d = DateTime.Now - query.FechaIngreso;
                double dias = d.Days;

                try
                {
                    if (dias >= 90)
                    {
                        return resultado = "Tarjeta de $1000";
                    }
                    else if (dias >= 180)
                    {
                        return resultado = "Tarjeta de $500";
                    }
                    return resultado = "Cliente Denegado";

                }
                catch
                {
                    return resultado = "Error al buscar Veraz";

                }
            }

        }
    }
}
