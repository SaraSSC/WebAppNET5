using Microsoft.AspNetCore.Mvc;
using WebAppNET5.Models;

namespace WebAppNET5.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Detalhe()
        {
            Cliente cliente = new Cliente()
            {
                ClienteId = 200,
                Nome = "Sara",
                Email = "sara.carvalho.21148@formandos.cinel.pt",
                Telefone = "9000007"
            };

            ViewBag.Nome = cliente.Nome;
            ViewData["Email"] = cliente.Email;

            //Passar o objecto para não dar erro quando o chamar na View
            return View(cliente);
        }

        //Inverso para receber os dados do formulário(View)
        [HttpPost]
        public IActionResult GuardarCliente(Cliente modelo)
        {
            return View(modelo);
        }
    }
}
