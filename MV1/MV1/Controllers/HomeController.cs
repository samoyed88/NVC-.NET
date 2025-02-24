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
        ViewBag.Msg = "�����L�o�A�F�����z";
        ViewBag.Title = "�x�W";
        return View();
    }
    public IActionResult Mcu()
    {
        ViewBag.Title = "�ʶ�";
        return View();
    }

    public IActionResult Yzu()
    {
        ViewBag.Title = "����";
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
