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
    }
}