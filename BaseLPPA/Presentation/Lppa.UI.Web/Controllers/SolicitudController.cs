using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lppa.Data;

namespace Lppa.UI.Web.Controllers
{
    public class SolicitudController : Controller
    {
        private LppaBD db = new LppaBD();

        // GET: Solicitud
        public ActionResult Index()
        {
            return View(db.Solicitud.ToList());
        }


        public ActionResult SolicitudCliente(string cliente, string dni)
        {
            ViewBag.Cliente = cliente;
            ViewBag.ClienteDNI = dni;
            return View();
        }

        public ActionResult ImprimirTarjeta(string cliente)
        {
            ViewBag.Cliente = cliente;
            return View();
        }


        [HttpPost]
        public ActionResult SolicitudCliente(ViewModels.ContratoViewModel solicitud, string cliente, string dni)
        {
            ViewBag.Cliente = cliente;
            ViewBag.ClienteDNI = dni;

            var customerFound = new ClienteRepository();
            var customer = customerFound.SearhByDNI(long.Parse(dni));

            var tarjetaFound = new TarjetaRepository();
            var tarjeta = tarjetaFound.searchByDNI(customer.ID);

            try
            {
                var s = new Solicitud()
                {
                    Celular = solicitud.Celular,
                    Email = solicitud.Email,
                    //FirmaCliente = solicitud.FirmaElectronica,
                    //FotoCliente = solicitud.Imagen,
                    ChangedBy = Guid.NewGuid().ToString().Substring(0, 8),
                    ChangedOn = DateTime.Now,
                    CreatedBy = Guid.NewGuid().ToString().Substring(0, 8),
                    CreatedOn = DateTime.Now,
                    CodEstado = 1,
                    IDCliente = customer.ID,
                    IDTarjeta = tarjeta.ID

                };
                db.Solicitud.Add(s);
                db.SaveChanges();

                ViewBag.Cliente = cliente;
                ViewBag.ClienteDNI = dni;
                return View();
            }
            catch
            {
                throw null;
            }


         
        }


        // GET: Solicitud/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitud solicitud = db.Solicitud.Find(id);
            if (solicitud == null)
            {
                return HttpNotFound();
            }
            return View(solicitud);
        }

        // GET: Solicitud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Solicitud/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IDCliente,IDTarjeta,CodEstado,FotoCliente,FirmaCliente,Email,Celular,CreatedBy,CreatedOn,ChangedBy,ChangedOn")] Solicitud solicitud)
        {
            if (ModelState.IsValid)
            {
                db.Solicitud.Add(solicitud);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(solicitud);
        }

        // GET: Solicitud/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitud solicitud = db.Solicitud.Find(id);
            if (solicitud == null)
            {
                return HttpNotFound();
            }
            return View(solicitud);
        }

        // POST: Solicitud/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IDCliente,IDTarjeta,CodEstado,FotoCliente,FirmaCliente,Email,Celular,CreatedBy,CreatedOn,ChangedBy,ChangedOn")] Solicitud solicitud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(solicitud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(solicitud);
        }

        // GET: Solicitud/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitud solicitud = db.Solicitud.Find(id);
            if (solicitud == null)
            {
                return HttpNotFound();
            }
            return View(solicitud);
        }

        // POST: Solicitud/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Solicitud solicitud = db.Solicitud.Find(id);
            db.Solicitud.Remove(solicitud);
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
