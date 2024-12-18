using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;


namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            var value = db.TblProject.Find(id);
            db.TblProject.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateProject(int id)
        {
            var value = db.TblProject.Find(id);
            return View(value);
        }
    }
}