using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CabineBarbearia.Models;

namespace CabineBarbearia.Controllers
{
    public class BarbeirosController : Controller
    {
        private CabineBarbeariaContexto db = new CabineBarbeariaContexto();

        // GET: Barbeiros
        public ActionResult Index()
        {
            return View(db.Barbeiroes.ToList());
        }

        // GET: Barbeiros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barbeiro barbeiro = db.Barbeiroes.Find(id);
            if (barbeiro == null)
            {
                return HttpNotFound();
            }
            return View(barbeiro);
        }

        // GET: Barbeiros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Barbeiros/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDBarbeiro,Nome,Apelido,Celular,Email,Admissao,Status")] Barbeiro barbeiro)
        {
            if (ModelState.IsValid)
            {
                db.Barbeiroes.Add(barbeiro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(barbeiro);
        }

        // GET: Barbeiros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barbeiro barbeiro = db.Barbeiroes.Find(id);
            if (barbeiro == null)
            {
                return HttpNotFound();
            }
            return View(barbeiro);
        }

        // POST: Barbeiros/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDBarbeiro,Nome,Apelido,Celular,Email,Admissao,Status")] Barbeiro barbeiro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(barbeiro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(barbeiro);
        }

        // GET: Barbeiros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barbeiro barbeiro = db.Barbeiroes.Find(id);
            if (barbeiro == null)
            {
                return HttpNotFound();
            }
            return View(barbeiro);
        }

        // POST: Barbeiros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Barbeiro barbeiro = db.Barbeiroes.Find(id);
            db.Barbeiroes.Remove(barbeiro);
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
