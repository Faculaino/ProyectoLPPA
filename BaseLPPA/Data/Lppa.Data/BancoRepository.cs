using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;

namespace Lppa.Data
{
    public class BancoRepository
    {
        Model db = new Model();

        public void Create(BancoEntity banco)
        {
            banco.CodBanco = int.Parse(Guid.NewGuid().ToString());
            banco.ChangedBy = Guid.NewGuid();
            banco.ChangedOn = DateTime.Now;
            banco.CreatedBy = Guid.NewGuid();
            banco.CreatedOn = DateTime.Now;
            banco.DeletedBy = Guid.NewGuid();
            banco.DeletedOn = DateTime.Now;
     
            db.TablaBanco.Add(banco);
            db.SaveChanges();

        }

        public List<BancoEntity> ListarTodos()
        {
            return db.TablaBanco.ToList();
        }
    }
}
