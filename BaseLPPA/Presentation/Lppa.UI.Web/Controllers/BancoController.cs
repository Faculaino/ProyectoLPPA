using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lppa.Data;
using Lppa.Entities;

namespace Lppa.UI.Web.Controllers
{
    public class BancoController : Controller
    {
        private Model db = new Model();

        // GET: Banco
        public ActionResult Index()
        {
            return View(db.TablaBanco.ToList());
        }

        // GET: Banco/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BancoEntity bancoEntity = db.TablaBanco.Find(id);
            if (bancoEntity == null)
            {
                return HttpNotFound();
            }
            return View(bancoEntity);
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
        public ActionResult Create([Bind(Include = "Id,CodBanco,RazonSocial,CUIT,Direccion,Telefono,Alias,RowId,CreatedOn,CreatedBy,ChangedOn,ChangedBy,DeletedOn,DeletedBy,IsDeleted")] BancoEntity bancoEntity)
        {
            if (ModelState.IsValid)
            {
                db.TablaBanco.Add(bancoEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bancoEntity);
        }

        // GET: Banco/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BancoEntity bancoEntity = db.TablaBanco.Find(id);
            if (bancoEntity == null)
            {
                return HttpNotFound();
            }
            return View(bancoEntity);
        }

        // POST: Banco/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CodBanco,RazonSocial,CUIT,Direccion,Telefono,Alias,RowId,CreatedOn,CreatedBy,ChangedOn,ChangedBy,DeletedOn,DeletedBy,IsDeleted")] BancoEntity bancoEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bancoEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bancoEntity);
        }

        // GET: Banco/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BancoEntity bancoEntity = db.TablaBanco.Find(id);
            if (bancoEntity == null)
            {
                return HttpNotFound();
            }
            return View(bancoEntity);
        }

        // POST: Banco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BancoEntity bancoEntity = db.TablaBanco.Find(id);
            db.TablaBanco.Remove(bancoEntity);
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
