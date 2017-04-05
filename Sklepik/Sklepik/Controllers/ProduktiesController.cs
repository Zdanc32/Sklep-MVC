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
    public class ProduktiesController : Controller
    {
        private SklepKomputerowyEntities db = new SklepKomputerowyEntities();

        // GET: Produkties
        public ActionResult Index()
        {
            var produkty = db.Produkty.Include(p => p.Kategorie_Producenci);
            return View(produkty.ToList());
        }

        // GET: Produkties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produkty produkty = db.Produkty.Find(id);
            if (produkty == null)
            {
                return HttpNotFound();
            }
            return View(produkty);
        }

        // GET: Produkties/Create
        public ActionResult Create()
        {
            ViewBag.id_katergoria_prod = new SelectList(db.Kategorie_Producenci, "Id_Kat_prod", "Id_Kat_prod");
            return View();
        }

        // POST: Produkties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_produktu,id_katergoria_prod,nazwa_produktu,typ,wersja,opis,zdjęcie,cena")] Produkty produkty)
        {
            if (ModelState.IsValid)
            {
                db.Produkty.Add(produkty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_katergoria_prod = new SelectList(db.Kategorie_Producenci, "Id_Kat_prod", "Id_Kat_prod", produkty.id_katergoria_prod);
            return View(produkty);
        }

        // GET: Produkties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produkty produkty = db.Produkty.Find(id);
            if (produkty == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_katergoria_prod = new SelectList(db.Kategorie_Producenci, "Id_Kat_prod", "Id_Kat_prod", produkty.id_katergoria_prod);
            return View(produkty);
        }

        // POST: Produkties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_produktu,id_katergoria_prod,nazwa_produktu,typ,wersja,opis,zdjęcie,cena")] Produkty produkty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produkty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_katergoria_prod = new SelectList(db.Kategorie_Producenci, "Id_Kat_prod", "Id_Kat_prod", produkty.id_katergoria_prod);
            return View(produkty);
        }

        // GET: Produkties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produkty produkty = db.Produkty.Find(id);
            if (produkty == null)
            {
                return HttpNotFound();
            }
            return View(produkty);
        }

        // POST: Produkties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produkty produkty = db.Produkty.Find(id);
            db.Produkty.Remove(produkty);
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
