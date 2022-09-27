
using Budget.Data;
using Budget.Models;
using Budget.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Budget.Controllers
{
    public class HomeController : Controller
    {
        private readonly BudgetContext _db;
        private readonly IDbService _dbService;
        public HomeController(BudgetContext db, IDbService dbService)
        {
            _db = db;
            _dbService = dbService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("AddConsumption")]
        public async Task<IActionResult> AddConsumption(Consumption consumption)
        {
            if (ModelState.IsValid)
            {
                await _dbService.AddConsumptionToDb(consumption, _db);
            }
            else
            {
                return StatusCode(500);
            }
            return RedirectToAction("Index"); 
        }
    }
}