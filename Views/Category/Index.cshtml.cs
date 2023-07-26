using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Data;
using BulkyBookWeb.Data.IRepository;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BulkyBookWeb.Views.Category
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public Index(ILogger<Index> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork=unitOfWork;
        }

        public void OnGet()
        {
        }
    }
}