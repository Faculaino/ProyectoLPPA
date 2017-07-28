using Lppa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lppa.UI.Web.Controllers
{
   
    public class ReporteController : Controller
    {
        private LppaBD db = new LppaBD();
    
        public ActionResult Principal()
        {
            return View();
        }

        public ActionResult ListaClientes()
        {
            return View(db.Cliente.ToList());
        }

        public ActionResult ListaClientesVISA()
        {
            try
            {
                var lista = (from a in db.Tarjeta join c in db.Cliente on a.IDCliente equals c.ID where a.Marca == "Visa" select new { c.Nombre, a.Marca, a.FechaEmision, a.FechaVencimiento, a.Limite }).ToList();
                var nuevaLista = new List<ViewModels.ClientesVisa>();

                foreach (var item in lista)
                {
                    var c = new ViewModels.ClientesVisa()
                    {
                        Nombre = item.Nombre,
                        MarcaTarjeta = item.Marca,
                        FechaEmision = item.FechaEmision,
                        FechaVencimiento = item.FechaVencimiento,
                        Limite = item.Limite
                    };

                    nuevaLista.Add(c);
                }

                return View(nuevaLista);
            }
            catch
            {
                return RedirectToAction("Principal");
            }
           
        }

        public ActionResult ListaClientesAMEX()
        {
            try
            {
                var lista = (from a in db.Tarjeta join c in db.Cliente on a.IDCliente equals c.ID where a.Marca == "American Express" select new { c.Nombre, a.Marca, a.FechaEmision, a.FechaVencimiento, a.Limite }).ToList();
                var nuevaLista = new List<ViewModels.ClientesAMEX>();

                foreach (var item in lista)
                {
                    var c = new ViewModels.ClientesAMEX()
                    {
                        Nombre = item.Nombre,
                        MarcaTarjeta = item.Marca,
                        FechaEmision = item.FechaEmision,
                        FechaVencimiento = item.FechaVencimiento,
                        Limite = item.Limite
                    };

                    nuevaLista.Add(c);
                }

                return View(nuevaLista);
            }
            catch
            {
                return RedirectToAction("Principal");
            }
        }

        public ActionResult ListaClientesMasterCard()
        {
            try
            {
                var lista = (from a in db.Tarjeta join c in db.Cliente on a.IDCliente equals c.ID where a.Marca == "MasterCard" select new { c.Nombre, a.Marca, a.FechaEmision, a.FechaVencimiento, a.Limite }).ToList();
                var nuevaLista = new List<ViewModels.ClientesMaster>();

                foreach (var item in lista)
                {
                    var c = new ViewModels.ClientesMaster()
                    {
                        Nombre = item.Nombre,
                        MarcaTarjeta = item.Marca,
                        FechaEmision = item.FechaEmision,
                        FechaVencimiento = item.FechaVencimiento,
                        Limite = item.Limite
                    };

                    nuevaLista.Add(c);
                }

                return View(nuevaLista);
            }
            catch
            {
                return RedirectToAction("Principal");
            }
        }

        public ActionResult ListaClientesEnVeraz()
        {
            var lista = new List<Veraz>();
            var listaFound = new VerazRepository();

            lista = listaFound.listaveraz();

            return View(lista);
        }
    }
}