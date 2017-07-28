using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Data
{
    public class CuentaRepository
    {
        public Usuario Login(Usuario user)
        {
            LppaBD db = new LppaBD();

            var query = db.Usuario.Where(o => o.Email == user.Email & o.Contraseña == user.Contraseña).FirstOrDefault();

            try
            {
                var nuevoUsuario = new Usuario()
                {
                    ID = query.ID,
                    Nombre = query.Nombre,
                    Apellido = query.Apellido,
                    Email = query.Email,
                    Contraseña = query.Contraseña,


                };
                return nuevoUsuario;

            }
            catch
            {
                return null;
            }


        }

        public void Registrar(Usuario user)
        {
            LppaBD bd = new LppaBD();

            var newUser = new Usuario()
            {
                Nombre = user.Nombre,
                Apellido = user.Apellido,
                Email = user.Email,
                Contraseña = user.Contraseña,
                FechaAlta = DateTime.Now,
                FechaBaja = DateTime.Now,
                CodEstado = 1,
                ChangedBy = Guid.NewGuid().ToString().Substring(0, 8),
                ChangedOn = DateTime.Now,
                CreatedBy = Guid.NewGuid().ToString().Substring(0, 8),
                CreatedOn = DateTime.Now,

            };

            try
            {
                bd.Usuario.Add(newUser);
                bd.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
