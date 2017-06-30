using Lppa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Data
{
    public class ClienteRepository
    {
        LppaBD db = new LppaBD();

        public void Create(ClienteEntity cliente)
        {
            
            cliente.ChangedBy = Guid.NewGuid().ToString();
            cliente.ChangedOn = DateTime.Now;
            cliente.CreatedBy = Guid.NewGuid().ToString();
            cliente.CreatedOn = DateTime.Now;
            cliente.CodEstado = int.Parse(Guid.NewGuid().ToString());

            db.TablaCliente.Add(cliente);
            db.SaveChanges();

        }

        public List<ClienteEntity> ListarTodos()
        {
            return null;
        }



    }
}
