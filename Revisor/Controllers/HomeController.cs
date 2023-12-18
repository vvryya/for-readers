using Microsoft.AspNetCore.Mvc;
using Revisor.Models;
using System.Data;
using System.Diagnostics;

namespace Revisor.Controllers
{
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
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Results()
        {
            EnumerableRowCollection<DataRow> custs = ViewBag.Customers;
            bool anyRows = custs.Any();

            if (anyRows == false)
            {
                return View("NoResults");
            }
            else
            {
                return View("OtherView");
            }
        }

        
    }
}
