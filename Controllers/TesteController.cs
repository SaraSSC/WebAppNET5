using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WebAppNET5.Controllers
{
    public class TesteController : Controller
    {
        //HACK: Contollers devem ter sempre o nome terminado com Controller!!!
        public IActionResult Index()
        {
            //return View();

            /*
            ViewData["Nome"] = "Sara";
            ViewData["Email"] = "sara.carvalho21148@formandos.cinel.pt";
            ViewData["Curso"] = "AST.NET MVC";
            ViewData["DataInicio"] = "2024-01-01";
            */

            /*
            ViewBag.Nome = "Sara";
            ViewBag.Email = "sara.carvalho21148@formandos.cinel.pt";
            ViewBag.Curso = "AST.NET MVC";
            ViewBag.DataInicio = "2024-01-01";
            */

           /* ViewBag.Paises = new List<string>
            {
                "Portugal",
                "Correia do Sul",
                "Japão",
                "China",
                "Espanha",
                "França",
                "Alemanha",
                "Itália"
            };
           */

            ViewData["Paises"] = new List<string>
            {
                "Portugal",
                "Correia do Sul",
                "Japão",
                "China",
                "Espanha",
                "França",
                "Alemanha",
                "Itália"
            };

            return View();
        }

        public string Inicio()
        {
            return "A minha primeira aplicação ASP.NET MVC!";
        }

        public string Saudacao(int id)
        {
            return $"Codigo da url: {id.ToString()}";

            /* /Teste/Saudacao?id=56+Xpto=100
             * vai depois sendo passado no form cada parametro
             */
        }
    }
}
