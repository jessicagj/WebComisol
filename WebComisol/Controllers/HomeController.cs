using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebComisol.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NuestraEmpresa()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Servicios()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Ventajas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cobertura()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contactanos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}