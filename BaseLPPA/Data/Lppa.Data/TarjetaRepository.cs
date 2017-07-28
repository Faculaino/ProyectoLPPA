using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lppa.Entities;
using System.Data.Entity.Validation;

namespace Lppa.Data
{
    public class TarjetaRepository
    {
        public void insert(TarjetaEntity tarjeta, long dni)
        {
            LppaBD db = new LppaBD();

            var t = new Tarjeta();

            var resultadoVeraz = new VerazRepository();
            string resultado = resultadoVeraz.ValidarVeraz(dni);
            
            if (resultado == "Cliente Denegado")
            {
                
            }
            else
            {
                t.ChangedBy = Guid.NewGuid().ToString().Substring(0, 8);
                t.ChangedOn = DateTime.Now;
                t.CreatedBy = Guid.NewGuid().ToString().Substring(0, 8);
                t.CreatedOn = DateTime.Now;
                t.CodEstado = 1;

                string[] valorSplit = resultado.Split('$');

                t.IDBanco = 1;
                t.Limite = int.Parse(valorSplit[1]);
                t.FechaVencimiento = 2;
                t.FechaEmision = DateTime.Now;
                t.CodVerificacion = 123;
                t.Marca = tarjeta.Marca;

                var IDCustomer = new ClienteRepository();
                var customer = IDCustomer.getID(dni);

                t.IDCliente = customer.ID;
                db.Tarjeta.Add(t);

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
            }


           


        }

        public List<Tarjeta> listaTcVISA()
        {
            LppaBD db = new LppaBD();
            var nuevaLista = new List<Tarjeta>();

            var lista = db.Tarjeta.Where(o => o.Marca == "Visa").ToList();

            try
            {
                foreach (var item in lista)
                {
                    var tarjeta = new Tarjeta()
                    {
                        ID = item.ID,
                        IDBanco = item.IDBanco,
                        IDCliente = item.IDCliente,
                        Limite = item.Limite,
                        Marca = item.Marca,
                        CodVerificacion = item.CodVerificacion,
                        ChangedBy = item.ChangedBy,
                        ChangedOn = item.ChangedOn,
                        CodEstado = item.CodEstado,
                        CreatedBy = item.CreatedBy,
                        CreatedOn = item.CreatedOn,
                        FechaEmision = item.FechaEmision,
                        FechaVencimiento = item.FechaVencimiento
                    };
                    nuevaLista.Add(tarjeta);
                   
                }
                return nuevaLista;
            }
            catch
            {
                return null;
            }
           

        }

        public List<Tarjeta> listaTcAMEX()
        {
            LppaBD db = new LppaBD();
            var nuevaLista = new List<Tarjeta>();

            var lista = db.Tarjeta.Where(o => o.Marca == "American Express").ToList();

            try
            {
                foreach (var item in lista)
                {
                    var tarjeta = new Tarjeta()
                    {
                        ID = item.ID,
                        IDBanco = item.IDBanco,
                        IDCliente = item.IDCliente,
                        Limite = item.Limite,
                        Marca = item.Marca,
                        CodVerificacion = item.CodVerificacion,
                        ChangedBy = item.ChangedBy,
                        ChangedOn = item.ChangedOn,
                        CodEstado = item.CodEstado,
                        CreatedBy = item.CreatedBy,
                        CreatedOn = item.CreatedOn,
                        FechaEmision = item.FechaEmision,
                        FechaVencimiento = item.FechaVencimiento
                    };
                    nuevaLista.Add(tarjeta);

                }
                return nuevaLista;
            }
            catch
            {
                return null;
            }


        }

        public List<Tarjeta> listaTcMaster()
        {
            LppaBD db = new LppaBD();
            var nuevaLista = new List<Tarjeta>();

            var lista = db.Tarjeta.Where(o => o.Marca == "MasterCard").ToList();

            try
            {
                foreach (var item in lista)
                {
                    var tarjeta = new Tarjeta()
                    {
                        ID = item.ID,
                        IDBanco = item.IDBanco,
                        IDCliente = item.IDCliente,
                        Limite = item.Limite,
                        Marca = item.Marca,
                        CodVerificacion = item.CodVerificacion,
                        ChangedBy = item.ChangedBy,
                        ChangedOn = item.ChangedOn,
                        CodEstado = item.CodEstado,
                        CreatedBy = item.CreatedBy,
                        CreatedOn = item.CreatedOn,
                        FechaEmision = item.FechaEmision,
                        FechaVencimiento = item.FechaVencimiento
                    };
                    nuevaLista.Add(tarjeta);

                }
                return nuevaLista;
            }
            catch
            {
                return null;
            }


        }


        public TarjetaEntity searchByDNI (int id)
        {
            LppaBD db = new LppaBD();
            var query = db.Tarjeta.Where(o => o.IDCliente == id).FirstOrDefault();

            try
            {
                var nuevaTarjeta = new TarjetaEntity()
                {
                    ID = query.ID,
                    IDCliente = query.IDCliente,
                    CodVerificacion = query.CodVerificacion,
                    FechaVencimiento = query.FechaVencimiento,
                    ChangedBy = query.ChangedBy,
                    ChangedOn = query.ChangedOn,
                    CodEstado = query.CodEstado,
                    CreatedBy = query.CreatedBy,
                    CreatedOn = query.CreatedOn,
                    IDBanco = query.IDBanco,
                    Limite = query.Limite,
                    Marca = query.Marca
                    

                };

                return nuevaTarjeta;

            }
            catch
            {
                return null;
            }
        }


    }
}
