using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;

namespace Lppa.Data
{
    public class ClienteRepository
    {
        Model db = new Model();

        public void Create(ClienteEntity cliente)
        {
            cliente.ChangedBy = Guid.NewGuid();
            cliente.ChangedOn = DateTime.Now;
            cliente.CreatedBy = Guid.NewGuid();
            cliente.CreatedOn = DateTime.Now;
            cliente.DeletedBy = Guid.NewGuid();
            cliente.DeletedOn = DateTime.Now;
            cliente.CodEstado = int.Parse(Guid.NewGuid().ToString());
            


            db.TablaCliente.Add(cliente);
            db.SaveChanges();
            
        }

        public List<ClienteEntity> ListarTodos()
        {
            return db.TablaCliente.ToList();
        }
    }
}
