using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Data.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Views.FoodType
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly IUnitOfWork unitOfWork;
        public IEnumerable<BulkyBookWeb.Models.FoodType> foodTypes {get; set;}

        public Index(ILogger<Index> logger, IUnitOfWork _db)
        {
            _logger = logger;
            unitOfWork = _db;
        }


        public void OnGet()
        {
            foodTypes = unitOfWork.FoodType.GetAll();

        }
    }
}