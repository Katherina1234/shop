using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using shop_proj.Models;

namespace shop_proj.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private Models.AppContext db;
        public UserController(Models.AppContext context, ILogger<UserController> logger)
        {
            
                db = context;
                _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            // return View(await db.Tovars.Include(u=>u.Images).ToListAsync());
             return View(await db.Tovars.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
