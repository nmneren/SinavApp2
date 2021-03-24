using Microsoft.AspNetCore.Mvc;
using SinavApp23MartMvcCore.Models.ModelVM;
using SinavApp23MartMvcCore.Models.ORM.Context;
using SinavApp23MartMvcCore.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavApp23MartMvcCore.Controllers
{
    public class DesingController : Controller
    {

        private readonly ProjectContext _db;

        public DesingController(ProjectContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ListVM result = new ListVM()
            {
                Menu = _db.Menus.ToList(),
                ContentList = _db.Contents.ToList()
            };


            return View(result);
        }

        public IActionResult ContentEkle(int? id)
        {
            var result = _db.Menus.Find(id);


            TempData["id"] = result.Id;
            TempData["name"] = result.Type;


            return View();

        }

        [HttpPost]
        public IActionResult ContentEkle(Content model)
        {
            _db.Contents.Add(model);

            var result = _db.SaveChanges() > 0 ? true : false;

            if (result)
            {
                return Redirect("/Desing/Index");
            }

            return View();
        }


        public IActionResult Edit(int? id)
        {
            return View(_db.Contents.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Content model)
        {
            _db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            var result = _db.SaveChanges() > 0 ? true : false;

            if (result)
            {
                return Redirect("/Desing/Index");
            }

            return View();
        }


        public IActionResult Delete(int? id)
        {
            _db.Contents.Remove(_db.Contents.Find(id));
            _db.SaveChanges();

            return Redirect("/Desing/Index");
        }
    }
}
