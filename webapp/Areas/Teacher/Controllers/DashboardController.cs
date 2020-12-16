using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;
using data.Models;
using data.IRepositories;

namespace webapp.Controllers
{
    [Area("Teacher")]
    public class DashboardController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly ISetClassesRepo _repo;

        // public Dashboard(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public DashboardController (ISetClassesRepo repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            IList<SetClass> setClasses = await _repo.GetSetClasses();
            return View(setClasses);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
