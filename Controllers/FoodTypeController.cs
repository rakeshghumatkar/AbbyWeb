using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Data;
using BulkyBookWeb.Data.IRepository;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BulkyBookWeb.Controllers
{
    [Route("[controller]")]
    public class FoodTypeController : Controller
    {
        private readonly ILogger<FoodTypeController> _logger;
        private readonly IUnitOfWork unitOfWork;
        public FoodTypeController(ILogger<FoodTypeController> logger, IUnitOfWork _db)
        {
            _logger = logger;
            unitOfWork = _db;
        }

        public IActionResult Index()
        {
            IEnumerable<FoodType> obj = unitOfWork.FoodType.GetAll();
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}