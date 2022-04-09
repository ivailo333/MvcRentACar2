using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcRentACar2.Data;
using MvcRentACar2.Models;
using System.Diagnostics;
using System.Linq;

namespace MvcRentACar2.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcRentACar2Context _mvcRentACar2Context;

        public HomeController(MvcRentACar2Context mvcRentACar2Context)
        {
            _mvcRentACar2Context = mvcRentACar2Context;
        }

        public IActionResult Index()
        {
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
}