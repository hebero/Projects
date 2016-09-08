using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            int hora;
            hora = DateTime.Now.Hour;
            if (hora < 12)
            {
                ViewBag.Saludo = "buenas tardes";
            }
            else
            {
                ViewBag.Saludo = "Buenas tardes";
            }

            return View();
        }
        [HttpGet]
        public ViewResult FormularioAlumno()
        {
            return View();
        }
        [HttpPost]
        public ViewResult FormularioAlumno(Alumno xAlumno)
        {
            if (ModelState.IsValid)
            {
                return View("RegistroAlumno", xAlumno);
            }
            else {
                return View();
            }
        }
    }
}