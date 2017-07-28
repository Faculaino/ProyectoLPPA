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

                TimeSpan d = DateTime.Now - DateTime.Parse(query.FechaIngreso.ToString());
                double dias = d.Days;

                try
                {
                    if (dias >= 1 && dias <= 90)
                    {
                        return resultado = "Tarjeta de $1000";
                    }
                    else if (dias >= 90 && dias <= 180)
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

        public List<Veraz> listaveraz()
        {
            LppaBD db = new LppaBD();
            var nuevaLista = new List<Veraz>();

            var lista = db.Veraz.Where(o => o.FechaIngreso != null).ToList();

            try
            {
                foreach (var item in lista)
                {
                    var vrz = new Veraz()
                    {
                        ID = item.ID,
                        DNI = item.DNI,
                        FechaIngreso = item.FechaIngreso,
                        FechaEgreso = item.FechaEgreso,
                        Observacion = item.Observacion
                        
                    };
                    nuevaLista.Add(vrz);

                }
                return nuevaLista;
            }
            catch
            {
                return null;
            }
        }


        



    }


    }

