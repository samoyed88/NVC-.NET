using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MV1.Models;

namespace MV1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Msg = "金光無罪，騙錢有理";
        ViewBag.Title = "台灣";
        return View();
    }
    public IActionResult Mcu()
    {
        ViewBag.Title = "銘傳";
        return View();
    }

    public IActionResult Yzu()
    {
        ViewBag.Title = "元智";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
