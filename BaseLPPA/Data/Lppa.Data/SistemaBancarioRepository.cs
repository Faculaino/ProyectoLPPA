using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;

namespace Lppa.Data
{
    public class SistemaBancarioRepository
    {
        Model db = new Model();

        public int ValidarSistemaBancario(long NroDoc)
        {
            // 0 = Cliente sin antecedentes bancarios o crediticios.
            // 2 = Cliente con antecedentes negativos.La solicitud debe ser rechazada.
            
            if (db.TablaSistemaBancario.Find(NroDoc) == null)
                return 1;
            else return 2;
        }
    }
}

