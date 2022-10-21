using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCtest.Models;

namespace MVCtest.Controllers
{
    public class TurnosController : Controller
    {
        static int numeroTurno = 0;
        private readonly ILogger<TurnosController> _logger;

        public TurnosController(ILogger<TurnosController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet] // Atributo
        public IActionResult CrearTurno(){
            return View();
        }
        
        [HttpPost] // Atributo
        public IActionResult CrearTurnoPost(Turno turno){
            turno.IdTurno = numeroTurno++;
            return View(turno);
        }
    }
}