using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sklepik.Models.DB;

namespace Sklepik.Controllers
{
    public class Galeria_zdjęcController : Controller
    {
        private SklepKomputerowyEntities db = new SklepKomputerowyEntities();

        // GET: Galeria_zdjęc
        public ActionResult Index()
        {
            var galeria_zdjęc = db.Galeria_zdjęc.Include(g => g.Produkty);
            return View(galeria_zdjęc.ToList());
        }

        // GET: Galeria_zdjęc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Galeria_zdjęc galeria_zdjęc = db.Galeria_zdjęc.Find(id);
            if (galeria_zdjęc == null)
            {
                return HttpNotFound();
            }
            return View(galeria_zdjęc);
        }

        // GET: Galeria_zdjęc/Create
        public ActionResult Create()
        {
            ViewBag.Id_Produktu = new SelectList(db.Produkty, "Id_produktu", "nazwa_produktu");
            return View();
        }

        // POST: Galeria_zdjęc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Galerii,Id_Produktu,nazwa,zdjęcie")] Galeria_zdjęc galeria_zdjęc)
        {
            if (ModelState.IsValid)
            {
                db.Galeria_zdjęc.Add(galeria_zdjęc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Produktu = new SelectList(db.Produkty, "Id_produktu", "nazwa_produktu", galeria_zdjęc.Id_Produktu);
            return View(galeria_zdjęc);
        }

        // GET: Galeria_zdjęc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Galeria_zdjęc galeria_zdjęc = db.Galeria_zdjęc.Find(id);
            if (galeria_zdjęc == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Produktu = new SelectList(db.Produkty, "Id_produktu", "nazwa_produktu", galeria_zdjęc.Id_Produktu);
            return View(galeria_zdjęc);
        }

        // POST: Galeria_zdjęc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Galerii,Id_Produktu,nazwa,zdjęcie")] Galeria_zdjęc galeria_zdjęc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(galeria_zdjęc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Produktu = new SelectList(db.Produkty, "Id_produktu", "nazwa_produktu", galeria_zdjęc.Id_Produktu);
            return View(galeria_zdjęc);
        }

        // GET: Galeria_zdjęc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Galeria_zdjęc galeria_zdjęc = db.Galeria_zdjęc.Find(id);
            if (galeria_zdjęc == null)
            {
                return HttpNotFound();
            }
            return View(galeria_zdjęc);
        }

        // POST: Galeria_zdjęc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Galeria_zdjęc galeria_zdjęc = db.Galeria_zdjęc.Find(id);
            db.Galeria_zdjęc.Remove(galeria_zdjęc);
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
