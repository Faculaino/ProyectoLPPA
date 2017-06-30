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
using Lppa.UI.Process;

namespace Lppa.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        private LppaBD db = new LppaBD();

        // GET: Cliente
        public ActionResult Index()
        {
            return View(db.Cliente.ToList());
        }

        // GET: Cliente/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ClienteEntity clienteEntity = db.TablaCliente.Find(id);
        //    if (clienteEntity == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(clienteEntity);
        //}

        
        
        public ActionResult Create()
        {
            return View();
        }

        //// POST: Cliente/Create
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,CodCliente,Nombre,Apellido,TipoDoc,NroDoc,Domicilio,EstadoCivil,Ingreso,Nacionalidad,Sexo,Ocupacion,CodEstado,FechaAlta,FechaBaja,RowId,CreatedOn,CreatedBy,ChangedOn,ChangedBy,DeletedOn,DeletedBy,IsDeleted")] ClienteEntity clienteEntity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.TablaCliente.Add(clienteEntity);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(clienteEntity);
        //}

        //// GET: Cliente/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ClienteEntity clienteEntity = db.TablaCliente.Find(id);
        //    if (clienteEntity == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(clienteEntity);
        //}

        //// POST: Cliente/Edit/5
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,CodCliente,Nombre,Apellido,TipoDoc,NroDoc,Domicilio,EstadoCivil,Ingreso,Nacionalidad,Sexo,Ocupacion,CodEstado,FechaAlta,FechaBaja,RowId,CreatedOn,CreatedBy,ChangedOn,ChangedBy,DeletedOn,DeletedBy,IsDeleted")] ClienteEntity clienteEntity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(clienteEntity).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(clienteEntity);
        //}

        //// GET: Cliente/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ClienteEntity clienteEntity = db.TablaCliente.Find(id);
        //    if (clienteEntity == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(clienteEntity);
        //}

        //// POST: Cliente/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    ClienteEntity clienteEntity = db.TablaCliente.Find(id);
        //    db.TablaCliente.Remove(clienteEntity);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
