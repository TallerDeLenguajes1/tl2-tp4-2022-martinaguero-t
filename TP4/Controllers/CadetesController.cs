using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class CadetesController : Controller
{
    private readonly ILogger<CadetesController> _logger;
    private static List<Cadete> cadetes = new List<Cadete>(); 

    public CadetesController(ILogger<CadetesController> logger)
    {
        _logger = logger;
    }

    public IActionResult listarCadetes(){
        return View(cadetes);
    }

    [HttpGet]   
    public IActionResult cargarCadete(){
        return View();
    }   

    [HttpPost]
    public IActionResult cargarCadetePost(Cadete cadete){
        cadetes.Add(cadete);
        return RedirectToAction("listarCadetes");
    }

    [HttpGet]
    public IActionResult eliminarCadete(){
        return View();
    }

    [HttpPost]
    public IActionResult eliminarCadetePost(int idCadete){
        cadetes.Remove(cadetes.Find(cadete => cadete.ID == idCadete));
        return RedirectToAction("listarCadetes");
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
