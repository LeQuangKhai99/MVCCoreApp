using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class ProductController : Controller
    {
        // https://localhost:8080/product/modify
        [Route("Product/modify")]
        public IActionResult Index()
        {
            return View();
        }

        // đánh dấu đây là action đặc biệt, ko gọi đc từ bên ngoài
        [NonAction]
        public string xxx()
        {
            return "Hello my friend";
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit()
        {
            return View();
        }
    }
}