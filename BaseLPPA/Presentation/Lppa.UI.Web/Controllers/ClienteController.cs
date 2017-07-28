using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lppa.Data;
using Lppa.UI.Process;
using Lppa.Entities;

namespace Lppa.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        private LppaBD db = new LppaBD();
        public string resultado { get; set; }

        public ActionResult Index()
        {
            ViewBag.Veraz = resultado;
            return View(db.Cliente.ToList());
        }

        public ActionResult PasosCliente()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contrato()
        {
            ViewBag.Progress = 3;
            return PartialView();
        }

        public ActionResult ValidarVeraz(long dni)
        {
            var vp = new VerazComponentController();
            resultado = vp.ValidarVeraz(dni);

            ViewBag.Veraz = resultado;
            ViewBag.DNI = dni;
            return RedirectToAction("Index", new { result = resultado });
        }

        [HttpPost]
        public ActionResult ValidarVeraz(string dni)
        {
            if (dni.ToString() == "Enviar consulta")
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                var vp = new VerazComponentController();
                resultado = vp.ValidarVeraz(long.Parse(dni));

                ViewBag.Veraz = resultado;

                var customerFound = new ClienteRepository();
                var customer = customerFound.getID(long.Parse(dni));
                string NombreCliente = customer.Nombre + " " + customer.Apellido; 
             
                return RedirectToAction("DatosCliente", new { result = resultado, dni = dni, cliente = NombreCliente});
                //return RedirectToAction("DatosCliente");
            }


        }

        [HttpPost]
        public ActionResult Index(long dni)
        {


            var ccc = new ClienteComponentController();
            var nuevoCliente = ccc.BuscarPorDNI(dni);

            if (nuevoCliente == null)
            {

                return View(new List<Lppa.Data.Cliente>());

            }
            else
            {
                var c = new Cliente()
                {
                    Nombre = nuevoCliente.Nombre,
                    Apellido = nuevoCliente.Apellido,
                    DNI = nuevoCliente.DNI,
                    Domicilio = nuevoCliente.Domicilio,
                    Sexo = nuevoCliente.Sexo,
                    Ocupacion = nuevoCliente.Ocupacion,
                    FechaNacimiento = nuevoCliente.FechaNacimiento,
                    EstadoCivil = nuevoCliente.EstadoCivil,
                    Ingreso = nuevoCliente.Ingreso,
                    ChangedBy = nuevoCliente.ChangedBy,
                    ChangedOn = nuevoCliente.ChangedOn,
                    CodEstado = nuevoCliente.CodEstado,
                    CreatedBy = nuevoCliente.CreatedBy,
                    CreatedOn = nuevoCliente.CreatedOn
                };


                var lista = new List<Cliente>();
                lista.Add(c);

                return View(lista);
            }


        }

        // GET: Cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Progress = 1;
            return View();


        }

        public ActionResult DatosCliente(string result, string dni, string cliente)
        {
            ViewBag.Cliente = cliente;
            ViewBag.ClienteDNI = dni;
            ViewBag.Veraz = result;
            return View();
        }

  


        [HttpPost]
        public ActionResult DatosCliente(ClienteEntity cliente)
        {
            var ccc = new ClienteComponentController();
            ccc.AgregarunCliente(cliente);
            
            ViewBag.Cliente = cliente.Nombre + " " + cliente.Apellido;
            ViewBag.ClienteDNI = cliente.DNI;
          
            //return RedirectToAction("Index", new { result = "", dni = cliente.DNI });
            ViewBag.Respuesta = "Cliente " + ViewBag.Cliente + " fue creado con Exito!!";
            return View();


        }

        // POST: Cliente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Nombre,Apellido,DNI,Domicilio,EstadoCivil,FechaNacimiento,Ingreso,Sexo,Ocupacion,CodEstado,CreatedBy,CreatedOn,ChangedBy,ChangedOn")] Cliente cliente)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Cliente.Add(cliente);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(cliente);
        //}

        // GET: Cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Apellido,DNI,Domicilio,EstadoCivil,FechaNacimiento,Ingreso,Sexo,Ocupacion,CodEstado,CreatedBy,CreatedOn,ChangedBy,ChangedOn")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Cliente.Find(id);
            db.Cliente.Remove(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
