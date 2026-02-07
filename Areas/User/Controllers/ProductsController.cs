using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MA_shop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MA_shop.Areas.User.Controllers
{
[Area("User")]
    public class ProductsController : Controller
    {
        

          ApplicationDbContext context = new ApplicationDbContext();
          public IActionResult Index()
        {
            var products = context.products.Include(p=>p.Category);
            return View("Index",products);
        }

    }
}