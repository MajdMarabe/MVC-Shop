using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MA_shop.Data;
using MA_shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MA_shop.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
public IActionResult Index()
        {
            var products = context.products.Include(p=>p.Category);
            return View("Index",products);
        }
        public IActionResult Create()
        {
           ViewBag.categories=context.categories.ToList();

            return View("Create");

        }
        public IActionResult Store(Product product, IFormFile Image)
        {
            if (Image != null && Image.Length > 0)
            {
          var fileName = Guid.NewGuid().ToString(); 
          fileName += Path.GetExtension(Image.FileName); 

          var filePath = Path.Combine(
        Directory.GetCurrentDirectory(),
        @"wwwroot\images",
        fileName
    );

          using (var stream = System.IO.File.Create(filePath))
    {
        Image.CopyTo(stream);
    }
           product.Image = fileName;

                context.products.Add(product);
                context.SaveChanges();
                return RedirectToAction("Index");
           }
         return View("Create",product);
        }
    }
}