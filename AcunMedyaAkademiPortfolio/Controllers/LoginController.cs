using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class LoginController : Controller
    {
        // GET: GirisYap
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(TblAdmin ad)
        {
            var bilgiler = db.TblAdmin.FirstOrDefault(x => x.Username == ad.Username && x.Password == ad.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Username, false);
                Session["Username"] = bilgiler.Username.ToString();
                return RedirectToAction("Index", "Contact");
            }
            else
            {
                return View();
            }
        }
    }
}