using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App13_ModelValid.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult verify(string name)
        {
            if (name == "Hasan")
            {
                return Json(new { msg = "Name already taken." });
            }
            else
            {
                return Json(new { msg = "" });
            }
        }


    }
}