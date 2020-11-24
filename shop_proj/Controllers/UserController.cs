using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using shop_proj.Models;

namespace shop_proj.Controllers
{
    public class UserController : Controller
    {
        private UserManager<User> _userManager;
        private readonly ILogger<UserController> _logger;
        private Models.AppContext db;
        public UserController(Models.AppContext context, ILogger<UserController> logger, UserManager<User> userManager)
        
{
                _userManager = userManager;

                db = context;
            _logger = logger;
        }
        public async Task<IActionResult> Tovarind(int? id)
        {
            SelectList kinds = new SelectList(db.Kinds.Where(c => c.TovarId == id), "Id", "Colour");
            ViewBag.Kinds = kinds;

            if (id != null)
            {
                Tovar user = await db.Tovars.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(await db.Tovars.Include(u => u.Kinds).ThenInclude(p => p.Images).FirstOrDefaultAsync(p => p.Id == id));

            }
            return NotFound();
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Tovars.Include(u => u.Kinds).ThenInclude(p => p.Images).ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public ActionResult GetImages(int id)
        {
            return PartialView(db.Images.Where(c => c.KindId == id).ToList());
        }
        public ActionResult GetSizes(int id)
        {
            return PartialView(db.Sizes.Where(c => c.KindId == id).ToList());
        }

        public async Task<object> Addkorzunaitem(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var id1 = _userManager.GetUserId(User);
            Size size = db.Sizes.FirstOrDefault(p => p.Id == id);
            Korzyna korzyna = await db.Korzuna.FirstOrDefaultAsync(p => p.UserId == id1 );
            if (korzyna==null) 
            { korzyna = new Korzyna { User = user }; 
                db.Korzuna.Add(korzyna); }
            korzyna = await db.Korzuna.FirstOrDefaultAsync(p => p.UserId == id1);
            Korzynaitem item = new Korzynaitem { Size = size, Korzyna = korzyna, Count = 1 };
            size.Count=size.Count-1;
             
            if (size.Count == 0)
                db.Sizes.Remove(size);
            else db.Sizes.Update(size);
            db.Korzynaitems.Add(item);
           
            await db.SaveChangesAsync();
            return korzyna.Id;
        }
        public async Task<IActionResult> Korzyna()
        {
            var id = _userManager.GetUserId(User);
            return View(await db.Korzuna.Include(u => u.Items).ThenInclude(i => i.Size).ThenInclude(p => p.Kind).ThenInclude(k => k.Tovar).Include(u=>u.Items).ThenInclude(i => i.Size).ThenInclude(p => p.Kind).ThenInclude(k => k.Images).FirstOrDefaultAsync(p => p.UserId == id));

        }
    }
}
