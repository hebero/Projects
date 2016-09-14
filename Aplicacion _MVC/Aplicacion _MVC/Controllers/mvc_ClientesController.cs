using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aplicacion__MVC;

namespace Aplicacion__MVC.Controllers
{
    public class mvc_ClientesController : Controller
    {
        private SalesERPDBEntities db = new SalesERPDBEntities();

        // GET: mvc_Clientes
        public ActionResult Index()
        {
            return View(db.mvc_Clientes.ToList());
        }

        // GET: mvc_Clientes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mvc_Clientes mvc_Clientes = db.mvc_Clientes.Find(id);
            if (mvc_Clientes == null)
            {
                return HttpNotFound();
            }
            return View(mvc_Clientes);
        }

        // GET: mvc_Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mvc_Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Cliente,Nit,RazonSocial")] mvc_Clientes mvc_Clientes)
        {
            if (ModelState.IsValid)
            {
                db.mvc_Clientes.Add(mvc_Clientes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mvc_Clientes);
        }

        // GET: mvc_Clientes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mvc_Clientes mvc_Clientes = db.mvc_Clientes.Find(id);
            if (mvc_Clientes == null)
            {
                return HttpNotFound();
            }
            return View(mvc_Clientes);
        }

        // POST: mvc_Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Cliente,Nit,RazonSocial")] mvc_Clientes mvc_Clientes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mvc_Clientes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mvc_Clientes);
        }

        // GET: mvc_Clientes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mvc_Clientes mvc_Clientes = db.mvc_Clientes.Find(id);
            if (mvc_Clientes == null)
            {
                return HttpNotFound();
            }
            return View(mvc_Clientes);
        }

        // POST: mvc_Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            mvc_Clientes mvc_Clientes = db.mvc_Clientes.Find(id);
            db.mvc_Clientes.Remove(mvc_Clientes);
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
