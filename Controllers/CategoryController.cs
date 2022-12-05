using Microsoft.AspNetCore.Mvc;
using MadRiverWeb.Models;
namespace MadRiverWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
