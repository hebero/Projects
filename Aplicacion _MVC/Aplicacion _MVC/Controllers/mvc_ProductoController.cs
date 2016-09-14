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
    public class mvc_ProductoController : Controller
    {
        private SalesERPDBEntities db = new SalesERPDBEntities();

        // GET: mvc_Producto
        public ActionResult Index()
        {
            return View(db.mvc_Producto.ToList());
        }

        // GET: mvc_Producto/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mvc_Producto mvc_Producto = db.mvc_Producto.Find(id);
            if (mvc_Producto == null)
            {
                return HttpNotFound();
            }
            return View(mvc_Producto);
        }

        // GET: mvc_Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mvc_Producto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Producto,Descripcion,Precio")] mvc_Producto mvc_Producto)
        {
            if (ModelState.IsValid)
            {
                db.mvc_Producto.Add(mvc_Producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mvc_Producto);
        }

        // GET: mvc_Producto/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mvc_Producto mvc_Producto = db.mvc_Producto.Find(id);
            if (mvc_Producto == null)
            {
                return HttpNotFound();
            }
            return View(mvc_Producto);
        }

        // POST: mvc_Producto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Producto,Descripcion,Precio")] mvc_Producto mvc_Producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mvc_Producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mvc_Producto);
        }

        // GET: mvc_Producto/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mvc_Producto mvc_Producto = db.mvc_Producto.Find(id);
            if (mvc_Producto == null)
            {
                return HttpNotFound();
            }
            return View(mvc_Producto);
        }

        // POST: mvc_Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            mvc_Producto mvc_Producto = db.mvc_Producto.Find(id);
            db.mvc_Producto.Remove(mvc_Producto);
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
