using AcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            using (var context = new DbPortfolioEntities())
            {
                var model = new PartialViewModel
                {
                    Table1Data = context.TblService.ToList(),
                    Table2Data = context.TblProfile.ToList(),
                    Table3Data = context.TblSocialMedia.ToList()
                };

                return PartialView("PartialFooter", model);
            }
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialHobby()
        {
            var values = db.TblHobby.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProjects()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonials()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialContact()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var skillcount = db.TblSkill.ToList().Count();
            var testimonialcount = db.TblTestimonial.ToList().Count();
            var projectcount = db.TblProject.ToList().Count();
            var servicecount = db.TblService.ToList().Count();
            ViewBag.SkillCount = skillcount;
            ViewBag.TestimonialCount = testimonialcount;
            ViewBag.ProjectCount = projectcount;
            ViewBag.ServiceCount = servicecount;
            return PartialView();
        }
    }
}