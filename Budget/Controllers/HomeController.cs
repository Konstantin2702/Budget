
using Budget.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Budget.Controllers
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

        [HttpPost, ActionName("AddConsumption")]
        public IActionResult AddConsumption(Consumption consumption)
        {
            Console.WriteLine(consumption.Cost);
            return Ok(); 
        }
    }
}