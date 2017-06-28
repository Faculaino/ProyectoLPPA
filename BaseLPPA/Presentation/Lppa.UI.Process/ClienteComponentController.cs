using Lppa.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;

namespace Lppa.UI.Process
{
    class ClienteComponentController
    {
        public void AgregarunCliente(ClienteEntity cliente)
        {
            var bc = new GestorBusinessComponent();
            bc.AgregarCliente(cliente);
        }

        public List<ClienteEntity> SeleccionarCliente()
        {
            var bc = new GestorBusinessComponent();
            return bc.SeleccionarCliente();
        }
    }
}
