using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public CategoryController(IUnitOfWork _db)
        {
            unitOfWork = _db;
            // var obj = new Category
            // {
            //     Name = "Think like switch",
            //     DisplayOrder = 299
            // };
            // var obj1 = new Category
            // {
            //     Name = "Think like switch edition 2",
            //     DisplayOrder = 399
            // };
            // db.categories.Add(obj);
            // db.categories.Add(obj1);
            // db.SaveChanges();
        }

        public IActionResult Index()
        {
            IEnumerable<Category> obj = unitOfWork.Category.GetAll();
            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Name and Display Order are same!");
            }
            if(ModelState.IsValid)
            {
                unitOfWork.Category.Add(obj);
                unitOfWork.Save();
                TempData["success"] = "Created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int Id)
        {
            if(Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = unitOfWork.Category.GetFirstOrDefault(x=>x.Id==Id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Name and Display Order are same!");
            }
            if(ModelState.IsValid)
            {
                unitOfWork.Category.Update(obj);
                unitOfWork.Save();
                TempData["success"] = "Updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int Id)
        {
            
            var obj = unitOfWork.Category.GetFirstOrDefault(x=>x.Id==Id);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int Id)
        {
            var obj = unitOfWork.Category.GetFirstOrDefault(x=>x.Id==Id);
            if(obj==null)
            {
                return NotFound();
            }
            unitOfWork.Category.Remove(obj);
            unitOfWork.Save();
            TempData["success"] = "Deleted successfully";
            return RedirectToAction("Index");
        }



    
    }
}