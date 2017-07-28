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
            var lista = new List<Tarjeta>();
            var listaFound = new TarjetaRepository();

            lista = listaFound.listaTcVISA();

            return View(lista);
        }

        public ActionResult ListaClientesAMEX()
        {
            var lista = new List<Tarjeta>();
            var listaFound = new TarjetaRepository();

            lista = listaFound.listaTcAMEX();

            return View(lista);
        }

        public ActionResult ListaClientesMasterCard()
        {
            var lista = new List<Tarjeta>();
            var listaFound = new TarjetaRepository();

            lista = listaFound.listaTcMaster();

            return View(lista);
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