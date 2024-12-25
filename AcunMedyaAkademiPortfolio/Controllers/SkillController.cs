using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class SkillController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult SkillList()
        {
            var values = db.TblSkill.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(TblSkill p)
        {
            db.TblSkill.Add(p);
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            db.TblSkill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TblSkill p)
        {
            var value = db.TblSkill.Find(p.SkillId);
            value.Title = p.Title;
            value.Value = p.Value;
            value.LastWeekValue = p.LastWeekValue;
            value.LastMonthValue = p.LastMonthValue;
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}