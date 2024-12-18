using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SendMessage()
        {
            return View();
        }
        public ActionResult MessageList()
        {
            return View();
        }
    }
}