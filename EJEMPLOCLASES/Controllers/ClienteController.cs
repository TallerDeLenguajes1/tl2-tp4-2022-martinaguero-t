using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCtest.Models;

namespace MVCtest.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public IActionResult AltaCliente(){
            return View();
        }

        [HttpPost]
        public IActionResult AltaClienteFormulario(Cliente cliente)
        {
            return View();
        }


/*      
        public string Index(int id, string name)
        {
            return $"Hola cliente {id}, tu nombre es {name} :)";
        }
*/
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}