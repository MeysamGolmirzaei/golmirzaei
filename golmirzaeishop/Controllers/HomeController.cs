using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using golmirzaeishop.Models;
using golmirzaeicore.Interfaces.Repository.User;
using golmirzaeicore.Interfaces.User;
using golmirzaeiCore.DTOs.User;

namespace golmirzaeishop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUser UserServices;

        public HomeController(IUser _UserServices)
        {
            UserServices = _UserServices;
        }

        public IActionResult Index()
        {
            ViewBag.Show = UserServices.FindAllUser();
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Vm_User l)
        {
            if (!ModelState.IsValid)
            {
                return View(l);
            }
            bool s = UserServices.Add(l);
            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var find = UserServices.FindUser(id);
            return View(find);
        }
        [HttpPost]
        public IActionResult Update(Vm_User k)
        {

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
