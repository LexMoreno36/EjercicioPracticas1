using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioPracticas1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DocVentas()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            return View();
        }
    }
}