using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class PostController : Controller
    {
        public IActionResult PostById(int id)
        {
            ViewBag.data = id;
            return View();
        }

        public IActionResult PostByName(string id)
        {
            ViewBag.data = id;
            return View();
        }
    }
}