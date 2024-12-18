using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;


namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class BannerController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblBanner.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateBanner()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBanner(TblBanner p)
        {
            db.TblBanner.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBanner(int id)
        {
            var value = db.TblBanner.Find(id);
            db.TblBanner.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateBanner(int id)
        {
            var value = db.TblBanner.Find(id);
            return View(value);
        }
    }
}