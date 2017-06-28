using Lppa.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;

namespace Lppa.UI.Process
{
    class BancoComponentController
    {
        public void AgregarunBanco(BancoEntity banco)
        {
            var bc = new GestorBusinessComponent();
            bc.AgregarBanco(banco);
        }

        public List<BancoEntity> SeleccionarBanco()
        {
            var bc = new GestorBusinessComponent();
            return bc.SeleccionarBanco();
        }
    }
}
