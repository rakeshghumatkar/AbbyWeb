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
    [BindProperties]
    public class Create : PageModel
    {
        private readonly ILogger<Create> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public BulkyBookWeb.Models.Category category {get; set;}

        public Create(ILogger<Create> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
        }
        
        // public void Task<IActionResult> OnPost()
        // {
        //     if (category.Name == category.DisplayOrder.ToString())
        //     {
        //         ModelState.AddModelError("Name", "Name and Display Order are same!");
        //     }
        //     if(ModelState.IsValid)
        //     {
        //         _unitOfWork.Category.Add(category);
        //         //await _unitOfWork.SaveAsync();
        //         _unitOfWork.Save();
        //         TempData["success"] = "Created successfully";
        //         //return RedirectToAction("Index");
        //     }
        //     //return View(obj);
        // }

    }
}