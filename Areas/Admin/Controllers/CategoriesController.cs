using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MA_shop.Data;
using MA_shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

namespace MA_shop.Areas.Admin.Controllers
{
[Area("Admin")]
    public class CategoriesController : Controller
    {
        
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.categories;
            return View("Index",categories);
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        public IActionResult Store(Category category)
        {
            if (ModelState.IsValid)
            {
            context.categories.Add(category);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));


            }
                        return View("Create");

        }
        public IActionResult Remove(int id )
        {
           Category category= context.categories.Find(id);
           context.categories.Remove(category);
           context.SaveChanges();
           return RedirectToAction("Index");
        }
        public IActionResult Edit(int id )
        {
            var category = context.categories.Find(id);

            return View(category);
            
        }
        public IActionResult update(Category category)
        {
            if (ModelState.IsValid)
            {
                
 context.categories.Update(category);
            context.SaveChanges();
            return RedirectToAction("Index");
            }
           
            return View("Edit",category);
        }
    }
}