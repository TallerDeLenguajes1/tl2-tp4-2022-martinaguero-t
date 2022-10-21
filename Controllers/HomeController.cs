using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCtest.Models;

namespace MVCtest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        return View();
    }

    public IActionResult Privacy()
    {   
        List<Cliente> clientes = new List<Cliente>();
        clientes.Add(new Cliente("Juan",32));
        clientes.Add(new Cliente("Maria",34));
        clientes.Add(new Cliente("Pocho",23));
        return View(clientes);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
