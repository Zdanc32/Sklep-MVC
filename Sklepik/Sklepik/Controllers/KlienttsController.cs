using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sklepik.Models.DB;

namespace Sklepik.Models
{
    public class KlienttsController : Controller
    {
        private SklepKomputerowyEntities db = new SklepKomputerowyEntities();

        // GET: Klientts
        public ActionResult Index()
        {
            var klientt = db.Klientt.Include(k => k.Adresy);
            return View(klientt.ToList());
        }

        // GET: Klientts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Klientt klientt = db.Klientt.Find(id);
            if (klientt == null)
            {
                return HttpNotFound();
            }
            return View(klientt);
        }

        // GET: Klientts/Create
        public ActionResult Create()
        {
            ViewBag.Id_Adresu = new SelectList(db.Adresy, "IdAdres", "miasto");
            return View();
        }

        // POST: Klientts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdKlient,Imie,Nazwisko,email,hasło,Nr_tele,Id_Adresu")] Klientt klientt)
        {
            if (ModelState.IsValid)
            {
                db.Klientt.Add(klientt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Adresu = new SelectList(db.Adresy, "IdAdres", "miasto", klientt.Id_Adresu);
            return View(klientt);
        }

        // GET: Klientts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Klientt klientt = db.Klientt.Find(id);
            if (klientt == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Adresu = new SelectList(db.Adresy, "IdAdres", "miasto", klientt.Id_Adresu);
            return View(klientt);
        }

        // POST: Klientts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdKlient,Imie,Nazwisko,email,hasło,Nr_tele,Id_Adresu")] Klientt klientt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(klientt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Adresu = new SelectList(db.Adresy, "IdAdres", "miasto", klientt.Id_Adresu);
            return View(klientt);
        }

        // GET: Klientts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Klientt klientt = db.Klientt.Find(id);
            if (klientt == null)
            {
                return HttpNotFound();
            }
            return View(klientt);
        }

        // POST: Klientts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Klientt klientt = db.Klientt.Find(id);
            db.Klientt.Remove(klientt);
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
