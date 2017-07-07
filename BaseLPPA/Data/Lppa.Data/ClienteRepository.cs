using Lppa.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lppa.Data
{
    public class ClienteRepository
    {
        LppaBD db = new LppaBD();

        public ClienteEntity Insert(ClienteEntity cliente)
        {
            var c = new Cliente();

            cliente.ChangedBy = Guid.NewGuid().ToString().Substring(0, 8);
            cliente.ChangedOn = DateTime.Now;
            cliente.CreatedBy = Guid.NewGuid().ToString().Substring(0, 8);
            cliente.CreatedOn = DateTime.Now;
            cliente.CodEstado = 1;

            c.Nombre = cliente.Nombre;
            c.Apellido = cliente.Apellido;
            c.DNI = cliente.DNI;
            c.EstadoCivil = cliente.EstadoCivil;
            c.Domicilio = cliente.Domicilio;
            c.CodEstado = cliente.CodEstado;
            c.FechaNacimiento = cliente.FechaNacimiento;
            c.Ocupacion = cliente.Ocupacion;
            c.Ingreso = cliente.Ingreso;
            c.Sexo = cliente.Sexo;
            c.ChangedBy = cliente.ChangedBy;
            c.ChangedOn = cliente.ChangedOn;
            c.CreatedBy = cliente.CreatedBy;
            c.CreatedOn = cliente.CreatedOn;
            
            
            db.Cliente.Add(c);

            try
            {
                db.SaveChanges();
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


            return cliente;

        }

        public List<ClienteEntity> ListarTodos()
        {
            return null;
        }

        public ClienteEntity SearhByDNI(long dni)
        {
            var query = db.Cliente.Where(o => o.DNI == dni).FirstOrDefault();

            try
            {
                var nuevoCliente = new ClienteEntity()
                {
                    Nombre = query.Nombre,
                    Apellido = query.Apellido,
                    DNI = query.DNI,
                    Domicilio = query.Domicilio,
                    EstadoCivil = query.EstadoCivil,
                    FechaNacimiento = query.FechaNacimiento,
                    Ingreso = query.Ingreso,
                    Ocupacion = query.Ocupacion,
                    Sexo = query.Sexo

                };
                return nuevoCliente;

            }
            catch
            {
                return null;
            }

        }



    }
}

