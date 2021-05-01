using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace MagnitudeConverter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }

}
