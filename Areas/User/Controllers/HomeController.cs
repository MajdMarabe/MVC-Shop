using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MA_shop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MA_shop.Areas.User.Controllers
{
[Area("User")]
    public class HomeController : Controller
    {
           ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories =context.categories;
            return View("Index",categories);
        }
    }
}