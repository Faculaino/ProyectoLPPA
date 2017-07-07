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


        public ActionResult Index()
        {
            return View(db.Cliente.ToList());

        }

        [HttpPost]
        public ActionResult Index(long dni)
        {

            var ccc = new ClienteComponentController();
            var nuevoCliente = ccc.BuscarPorDNI(dni);

            if (nuevoCliente == null)
            {
                //return RedirectToAction("Index");
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
            return View();
        }

        [HttpPost]
        public void Create(ClienteEntity cliente)
        {
            var ccc = new ClienteComponentController();
            ccc.AgregarunCliente(cliente);
            
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
