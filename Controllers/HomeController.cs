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
            ViewData["Nome"] = "Domingos Ribeiro";
            ViewData["Email"] = "domingos.ribeiro.net@gmail.com";
            ViewData["Curso"] = "Programação ASP.NET";
            ViewData["DataInicio"] = new DateTime(2021, 05, 30);

            return View();
        }

   
    }
}