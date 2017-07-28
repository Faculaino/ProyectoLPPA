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
    public class BancoController : Controller
    {
        private LppaBD db = new LppaBD();

        // GET: Banco
        public ActionResult Index()
        {
            return View(db.Banco.ToList());
        }

        // GET: Banco/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banco banco = db.Banco.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        // GET: Banco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Banco/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,CUIT,Direccion,CreatedBy,CreatedOn,ChangedBy,ChangedOn")] Banco banco)
        {
            if (ModelState.IsValid)
            {
                db.Banco.Add(banco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(banco);
        }

        // GET: Banco/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banco banco = db.Banco.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        // POST: Banco/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,CUIT,Direccion,CreatedBy,CreatedOn,ChangedBy,ChangedOn")] Banco banco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(banco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banco);
        }

        // GET: Banco/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banco banco = db.Banco.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        // POST: Banco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Banco banco = db.Banco.Find(id);
            db.Banco.Remove(banco);
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
