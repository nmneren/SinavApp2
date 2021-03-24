using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SinavApp23MartMvcCore.Models;
using SinavApp23MartMvcCore.Models.ModelVM;
using SinavApp23MartMvcCore.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SinavApp23MartMvcCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectContext _db;

        public HomeController(ProjectContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View(_db.Menus.ToList());
        }

        public IActionResult Content(int? id)
        {

            var ContentList = _db.Contents.Where(x => x.MenuId == id).ToList();
            var MenuName = _db.Menus.Find(id);

            MenuContentVM result = new MenuContentVM()
            {
                ContentList = ContentList,
                Menu = MenuName
            };


            return View(result);
        }

        public IActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Admin(AdminVM Model)
        {
            AdminVM admin = new AdminVM()
            {
                Name = "numan",
                Password = "123"
            };

            if (admin.Name == Model.Name && admin.Password == Model.Password)
            {
                return Redirect("/Desing/Index");
            }

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
