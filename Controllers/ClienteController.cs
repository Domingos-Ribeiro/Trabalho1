using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabalho1.Models;

namespace Trabalho1.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Detalhe_Cliente()
        {
            Cliente cliente = new Cliente()
            {
                ClienteId = 200,
                Nome = "Domingos Ribeiro",
                Email = "domigos.ribeiro.net@gmail.com",
                Telefone = "915445021"

            };

            // Possibilidade de usar o ViewBag para passar os dados para a View
            //ViewBag.ClienteId = cliente.ClienteId;
            //ViewBag.Nome = cliente.Nome;

            return View(cliente);
        }

        public ActionResult SalvarCliente()
        {
            return View();
        }
    }
}