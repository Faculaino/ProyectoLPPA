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
    public class TarjetaController : Controller
    {
        private LppaBD db = new LppaBD();

        // GET: Tarjeta
        public ActionResult Index()
        {
            return View(db.Tarjeta.ToList());
        }

        // GET: Tarjeta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarjeta tarjeta = db.Tarjeta.Find(id);
            if (tarjeta == null)
            {
                return HttpNotFound();
            }
            return View(tarjeta);
        }

        // GET: Tarjeta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarjeta/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IDBanco,IDCliente,Marca,FechaEmision,FechaVencimiento,CodVerificacion,Limite,CodEstado,CreatedBy,CreatedOn,ChangedBy,ChangedOn")] Tarjeta tarjeta)
        {
            if (ModelState.IsValid)
            {
                db.Tarjeta.Add(tarjeta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tarjeta);
        }

        // GET: Tarjeta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarjeta tarjeta = db.Tarjeta.Find(id);
            if (tarjeta == null)
            {
                return HttpNotFound();
            }
            return View(tarjeta);
        }

        // POST: Tarjeta/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IDBanco,IDCliente,Marca,FechaEmision,FechaVencimiento,CodVerificacion,Limite,CodEstado,CreatedBy,CreatedOn,ChangedBy,ChangedOn")] Tarjeta tarjeta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarjeta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tarjeta);
        }

        // GET: Tarjeta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarjeta tarjeta = db.Tarjeta.Find(id);
            if (tarjeta == null)
            {
                return HttpNotFound();
            }
            return View(tarjeta);
        }

        // POST: Tarjeta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tarjeta tarjeta = db.Tarjeta.Find(id);
            db.Tarjeta.Remove(tarjeta);
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
