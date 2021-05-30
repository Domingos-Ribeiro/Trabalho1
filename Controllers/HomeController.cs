using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trabalho1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Usando o ViewData (Mais antigo)
            //ViewData["Nome"] = "Domingos Ribeiro";
            //ViewData["Email"] = "domingos.ribeiro.net@gmail.com";
            //ViewData["Curso"] = "Programação ASP.NET";
            //ViewData["DataInicio"] = new DateTime(2021, 05, 30);


            // Usando o ViewBag (Mais recente)
            ViewBag.Nome = "Domingos Ribeiro";
            ViewBag.Email = "domingos.ribeiro.net@gmail.com";
            ViewBag.Curso = "Programação ASP.NET";
            ViewBag.DataInicio = new DateTime(2021, 05, 30);


            return View();
        }

   
    }
}