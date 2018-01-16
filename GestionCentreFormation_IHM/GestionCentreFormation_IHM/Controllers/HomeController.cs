using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionCentreFormation_IHM.Controllers
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

        public ActionResult Data(string id)
        {
            //return "<html><body><h1>Je suis une chaine de caractère avec " + (id ?? "rien") + " comme paramètre</h1></body></html>";

            ViewBag.msg = id;

            return View();
        }
    }
}