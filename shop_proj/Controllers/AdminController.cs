﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shop_proj.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                return View();
            }
            else
            {
                db.Categories.Add(user);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
           
        }
        public IActionResult Addtovar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addtovar(Tovar user)
        {
            if (ModelState.IsValid)
            {
                db.Tovars.Add(user);
                await db.SaveChangesAsync();
                return RedirectToAction("Tovarinf", new { id = user.Id });
            }
            else
                return View();
           

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
            ViewBag.sizes = new List<String> { "XS", "S", "M", "L", "XL", "XXL", "XXL" };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addkind(Kind user, List<IFormFile> uploadedFiles, int xxs, int xs, int s, int m, int l, int xl, int xxl)
        {
            Image img = new Image();
            Tovar tovar = await db.Tovars.FirstOrDefaultAsync(p => p.Id == user.TovarId);
            Size size = new Size();

            Kind kind = new Kind { Colour = user.Colour, Tovar = tovar };

            db.Kinds.Add(kind);
            foreach (var uploadedFile in uploadedFiles)
            {
                if (uploadedFile != null)
                {
                    img.Name = uploadedFile.FileName;
                    string path = "/Images/" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    Image file = new Image { Name = uploadedFile.FileName, Path = path, Kind = kind };
                    db.Images.Add(file);

                }
            }
            List<Size> tt = new List<Size> { new Size("xxs", xxs),
            new Size("xs",xs), new Size ("s",s), new Size("m",m), new Size("l",l), new Size("xl",xl), new Size("xxl",xxl) };
          
            foreach (var item in tt)
            {
                if (item.Count != 0)
                {
                    Size file = new Size { Name = item.Name, Count = item.Count, Kind = kind };
                    db.Sizes.Add(file);
                }
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
