using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Mess = "i don't care at all " + id;
            ViewBag.mess = model.Mess;
            return View(model);
        }
    }
}