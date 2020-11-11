using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shop_proj.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace shop_proj.Controllers
{
   
    public class AdminController : Controller
    {
        private Models.AppContext db;
        IWebHostEnvironment _appEnvironment;
        public AdminController(Models.AppContext context, IWebHostEnvironment appEnvironment)
        {
            db = context;
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Tovars.ToListAsync());
        }
        public IActionResult Addcategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addcategory(Category user)
        {
            db.Categories.Add(user);


            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Addtovar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addtovar(Tovar user)
        {
            db.Tovars.Add(user);          
            await db.SaveChangesAsync();
            return RedirectToAction("Tovarinf", new { id = user.Id });
        }
        public async Task<IActionResult> Tovarinf(int? id)
        {
            if (id != null)
            {
                Tovar user = await db.Tovars.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(await db.Tovars.Include(u => u.Kinds).FirstOrDefaultAsync(p => p.Id == id));

            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Tovarinf(Tovar user)
        {
            db.Tovars.Update(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult AddKind(int? id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addkind(Kind user, IFormFile uploadedFile)
        {
            Image img = new Image();
            Tovar tovar = await db.Tovars.FirstOrDefaultAsync(p => p.Id == user.TovarId);
     
            Kind kind = new Kind { Colour = user.Colour, Size = user.Size, Tovar = tovar };

            db.Kinds.Add(kind);
            if (uploadedFile != null)
            {
                img.Name = uploadedFile.FileName;
                string path = "/Images/" + uploadedFile.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                 Image file = new Image { Name = uploadedFile.FileName, Path = path, Kind=user};
                  db.Images.Add(file);

            }

            await db.SaveChangesAsync();
            return RedirectToAction("Tovarinf",  new { id=tovar.Id });
        }
        public async Task<IActionResult> Editkind(int? id)
        {
            if (id != null)
            {
                Kind user = await db.Kinds.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Editkind(Kind user)
        {
            
            db.Kinds.Update(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Tovarinf", new { id = user.TovarId });
        }
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Tovar user = await db.Tovars.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Tovar user = await db.Tovars.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                {
                    db.Tovars.Remove(user);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

    }
}
