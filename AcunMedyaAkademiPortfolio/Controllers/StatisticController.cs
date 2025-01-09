using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.HobbyCount = db.TblHobby.Count();
            ViewBag.skillAvgValue = db.TblSkill.Average(x=>x.Value);
            ViewBag.GetLastSkillTitle = db.GetLastSkillTitle().FirstOrDefault();
            ViewBag.mvcCategoryProjectCount1 = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.mvcCategoryProjectCount2 = db.TblProject.Where(x => x.ProjectCategory == 2).Count();
            ViewBag.mvcCategoryProjectCount3 = db.TblProject.Where(x => x.ProjectCategory == 3).Count();
            ViewBag.mvcCategoryProjectCount4 = db.TblProject.Where(x => x.ProjectCategory == 4).Count();
            return View();
        }
    }
}