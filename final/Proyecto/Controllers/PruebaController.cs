using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class PruebaController : Controller
    {
        //
        // GET: /Prueba/

        public ActionResult Index()
        {
            ViewBag("cualquier texto");
            return View();
        }

    }
}
