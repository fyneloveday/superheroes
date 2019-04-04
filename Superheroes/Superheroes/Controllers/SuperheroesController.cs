using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class SuperheroesController : Controller
    {
        private ApplicationDbContext db;
        public SuperheroesController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Superhero
        public ActionResult Index()
        {
            var superhero = db.Superheroes.ToList();
            return View(superhero);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            var superhero = db.Superheroes.Find(id);
            return View(superhero);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                db.Superheroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(superhero);
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            var superhero = db.Superheroes.Find(id);
            return View(superhero);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                db.Entry(superhero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View(superhero);
            }


        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int? id)
        {
            var superhero = db.Superheroes.Find(id);
            return View(superhero);
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                var superhero = db.Superheroes.Find(id);
                db.Superheroes.Remove(superhero);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
