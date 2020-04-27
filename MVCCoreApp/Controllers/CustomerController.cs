using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    [Route("khach-hang")]
    public class CustomerController : Controller
    {
        [Route("vip")]
        public IActionResult Vip(int id)
        {
            ViewBag.cus = "Hello khack vip " + id;
            return View("Index");
        }
        [Route("")]
        [Route("normal/{id}")]
        public IActionResult Normal(int id)
        {
            ViewBag.cus = "Hello khach thuong " + id;
            return View("Index");
        }
    }
}