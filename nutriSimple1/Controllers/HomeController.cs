using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nutriSimple1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Rendezvous()
        {
            ViewBag.Message = "Gestions des RENDEZ-VOUS.";

            return View();
        }
        public ActionResult DeplacerRDV()
        {
            ViewBag.Message = "PLANIFIER/DÉPLACER VOS RENDEZ-VOUS.";

            return View();
        }
        public ActionResult AutresRDV()
        {
            ViewBag.Message = "Autres RENDEZ-VOUS.";

            return View();
        }
        public ActionResult JournalAlimentaire()
        {
            ViewBag.Message = "Journal alimentaire.";

            return View();
        }
    }
}