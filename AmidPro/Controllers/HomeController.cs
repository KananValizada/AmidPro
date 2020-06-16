using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AmidPro.Models;
using Repository.Data;
using Repository.Repositories;

namespace AmidPro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AmidDbContext _dbcontext;
        private readonly ICarRepository _carRepository;

        public HomeController(ILogger<HomeController> logger, AmidDbContext context, ICarRepository carRepository )
        {
            _logger = logger;
            _dbcontext = context;
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            var model = _carRepository.GetCars();
            return View(model);
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
