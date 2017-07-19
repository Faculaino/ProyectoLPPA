﻿using System;
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
        public string resultado;


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

        [HttpPost]
        public ActionResult ValidarVeraz(long dni)
        {
            if (dni.ToString() == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                var vp = new VerazComponentController();
                resultado = vp.ValidarVeraz(dni);

                ViewBag.Veraz = resultado;
                ViewBag.DNI = dni;

                return RedirectToAction("Index");
            }

            
        }

        //[HttpGet]
        //public ActionResult ValidarVeraz(long dni)
        //{

        //    var vp = new VerazComponentController();
        //    var resultado = vp.ValidarVeraz(dni);

        //    ViewBag.Veraz = resultado;

        //    return RedirectToAction("Index");
        //}

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

        [HttpPost]
        public ActionResult Create(ClienteEntity cliente)
        {
            ViewBag.Progress = 1;
            if (ViewBag.Progress == 1)
            {
                var ccc = new ClienteComponentController();
                ccc.AgregarunCliente(cliente);
                ViewBag.Cliente = cliente.Nombre + " " + cliente.Apellido;
                ViewBag.ClienteDNI = cliente.DNI;
                ViewBag.Progress = 2;
                return RedirectToAction("Index","Cliente", new {dni = cliente.DNI });

            }
            else if (ViewBag.Progress == 2)
            {

                ViewBag.Progress = 3;
                return View();

            }
            else if (ViewBag.Progress == 3)
            {
                ViewBag.Progress = 3;
                return View();

            }
            else if (ViewBag.Progress == 4)
            {
                ViewBag.Progress = 4;
                return View();


            }
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
