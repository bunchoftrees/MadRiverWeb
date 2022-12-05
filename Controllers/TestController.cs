using Microsoft.AspNetCore.Mvc;
using MadRiverWeb.Models;
namespace MadRiverWeb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}