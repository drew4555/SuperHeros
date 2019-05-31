using Supers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Supers.Controllers
{
    public class SuperheroController : Controller
    {
        
        ApplicationDbContext db;
        SuperHero superhero;
        public SuperheroController()
        {
            db = new ApplicationDbContext();
            superhero = new SuperHero();
            
        }
        // GET: Superhero
        public ActionResult Index()
        {
            return View();
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            SuperHero hero = db.SuperHeroes.Find(id);
            return View(hero);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                db.SuperHeroes.Add(superHero);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Details()
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();   
            }
        }
        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero hero = db.SuperHeroes.Find(id);
            return View(hero);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(SuperHero superHero)
        {
            try
            {
                db.Entry(superHero).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            SuperHero hero = db.SuperHeroes.Find(id);
            return View(hero);
        }

        // POST: Superhero/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                SuperHero hero = db.SuperHeroes.Find(id);
                db.SuperHeroes.Remove(hero);
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
