using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace firstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index() //Get  -- /HelloWorld/
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1) //Get -- /HelloWorld/Welcome/
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
