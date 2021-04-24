using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConverterService.Controllers
{
    public class ConverterController : Controller
    {
        [HttpPost]
        public string Speed()
        {
            return "Speed";
        }

        [HttpPost]
        public string Lenght()
        {
            return "Lenght";
        }

        [HttpPost]
        public string Temperature()
        {
            return "Temperature";
        }

        [HttpPost]
        public string Weight()
        {
            return "Weight";
        }

    }
}
