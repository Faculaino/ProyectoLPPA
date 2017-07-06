using Lppa.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;
using Lppa.Data;

namespace Lppa.UI.Process
{
    public class ClienteComponentController
    {
        public ClienteEntity AgregarunCliente(ClienteEntity cliente)
        {
            var bc = new GestorBusinessComponent();
            return bc.AgregarCliente(cliente);
        }

        public List<ClienteEntity> SeleccionarCliente()
        {
            var bc = new GestorBusinessComponent();
            return bc.SeleccionarCliente();
        }

        public ClienteEntity BuscarPorDNI(long dni)
        {
            var bc = new GestorBusinessComponent();
            return bc.SearchCliente(dni);
        }
    }
}
