using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext db;
        public SuperheroController()
        {
            db = new ApplicationDbContext();
        }
        
        // GET: Superhero
        public ActionResult Index()
        {
            List<Superhero> superheroes = db.Superheroes.ToList();
            return View(superheroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = db.GetSuperhero(id);

            return View(superhero);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName, LastName, Alterego, primaryAbilities, secondaryAbilities")] Superhero superhero)
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
                ViewBag.message = "Sorry, but you must enter the required information.";
                return View(superhero);
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "FirstName, LastName, Alterego, primaryAbilities, secondaryAbilities")] Superhero superhero)
        {
            //try
            {
                // TODO: Add update logic here
                db.Entry(superhero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
              
            }
            //catch
            
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include = "FirstName, LastName, Alterego")] Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
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
