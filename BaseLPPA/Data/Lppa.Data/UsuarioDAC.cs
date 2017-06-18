using Lppa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Data
{
    public class UsuarioDAC : DataAccessComponent
    {
        LppaContext cx = new LppaContext();

        public void Create(Usuario user)
        {
            cx.Usuario.Add(user);
            SetAudit(user);
            cx.SaveChanges();
        }

        public List<Usuario> Select()
        {
            return cx.Usuario.ToList();
           
        }

        public void Edit(Usuario user)
        {
            cx.Entry(user).State = System.Data.Entity.EntityState.Modified;
            cx.SaveChanges();
        }

        public void Delete(Usuario user)
        {
            cx.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            cx.SaveChanges();
        }
    }
}
