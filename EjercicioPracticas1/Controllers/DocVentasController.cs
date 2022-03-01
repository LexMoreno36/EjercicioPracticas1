using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EjercicioPracticas1.Models;

namespace EjercicioPracticas1.Controllers
{
    public class DocVentasController : Controller
    {
        private EjercicioPracticasEntities db = new EjercicioPracticasEntities();

        // GET: DocVentas
        public ActionResult Index()
        {
            var docVentas = db.DocVentas.Include(d => d.Usuarios);
            return View(docVentas.ToList());
        }

        // GET: DocVentas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocVentas docVentas = db.DocVentas.Find(id);
            if (docVentas == null)
            {
                return HttpNotFound();
            }
            return View(docVentas);
        }

        // GET: DocVentas/Create
        public ActionResult Create()
        {
            ViewBag.IdCliente = new SelectList(db.Usuarios, "IdCliente", "Nombre");
            return View();
        }

        // POST: DocVentas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumeroPedido,EstadoPedido,DescPedido,IdCliente")] DocVentas docVentas)
        {
            if (ModelState.IsValid)
            {
                db.DocVentas.Add(docVentas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCliente = new SelectList(db.Usuarios, "IdCliente", "Nombre", docVentas.IdCliente);
            return View(docVentas);
        }

        // GET: DocVentas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocVentas docVentas = db.DocVentas.Find(id);
            if (docVentas == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCliente = new SelectList(db.Usuarios, "IdCliente", "Nombre", docVentas.IdCliente);
            return View(docVentas);
        }

        // POST: DocVentas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumeroPedido,EstadoPedido,DescPedido,IdCliente")] DocVentas docVentas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(docVentas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCliente = new SelectList(db.Usuarios, "IdCliente", "Nombre", docVentas.IdCliente);
            return View(docVentas);
        }

        // GET: DocVentas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocVentas docVentas = db.DocVentas.Find(id);
            if (docVentas == null)
            {
                return HttpNotFound();
            }
            return View(docVentas);
        }

        // POST: DocVentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DocVentas docVentas = db.DocVentas.Find(id);
            db.DocVentas.Remove(docVentas);
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
