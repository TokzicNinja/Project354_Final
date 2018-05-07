using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_Final_354;

namespace Project_Final_354.Controllers
{
    public class GameGenresController : Controller
    {
        private ProjectDBEntities db = new ProjectDBEntities();


        [HttpGet]
        public JsonResult isExists(string GameGenre)
        {
            return Json(!db.GameGenres.Any(x => x.GameGenre1 == GameGenre), JsonRequestBehavior.AllowGet);
        }

        // GET: GameGenres
        public ActionResult Index()
        {
            return View(db.GameGenres.ToList());
        }

        // GET: GameGenres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameGenre gameGenre = db.GameGenres.Find(id);
            if (gameGenre == null)
            {
                return HttpNotFound();
            }
            return View(gameGenre);
        }

        // GET: GameGenres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameGenres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameGenreID,GameGenre1")] GameGenre gameGenre)
        {
            if (ModelState.IsValid)
            {
                db.GameGenres.Add(gameGenre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameGenre);
        }

        // GET: GameGenres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameGenre gameGenre = db.GameGenres.Find(id);
            if (gameGenre == null)
            {
                return HttpNotFound();
            }
            return View(gameGenre);
        }

        // POST: GameGenres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameGenreID,GameGenre1")] GameGenre gameGenre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameGenre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameGenre);
        }

        // GET: GameGenres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameGenre gameGenre = db.GameGenres.Find(id);
            if (gameGenre == null)
            {
                return HttpNotFound();
            }
            return View(gameGenre);
        }

        // POST: GameGenres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameGenre gameGenre = db.GameGenres.Find(id);
            db.GameGenres.Remove(gameGenre);
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
