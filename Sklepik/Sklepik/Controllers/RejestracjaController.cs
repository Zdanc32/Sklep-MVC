using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Mvc;
using Sklepik.Models.DB;


namespace Sklepik.Controllers
{
    public class RejestracjaController : Controller
    {
        private SklepKomputerowyEntities db = new SklepKomputerowyEntities();
        //Home
        public ActionResult Index()
        {
            ViewBag.Id_Adresu = new SelectList(db.Adresy, "IdAdres", "miasto");
            return View();
        }

        // POST: Klientts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "IdKlient,Imie,Nazwisko,email,hasło,Nr_tele,Id_Adresu")] Klientt klientt)
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
    }
}