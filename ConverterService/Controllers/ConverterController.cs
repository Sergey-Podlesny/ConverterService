using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConverterService.Controllers
{
    public class ConverterController : Controller
    {

        private IActionResult Magnitude(List<string> magnitudes, string action)
        {
            ViewBag.Magnitudes = magnitudes;
            ViewBag.Action = action;
            return View("Magnitude");
        }


        // Get controller/speed
        public IActionResult Speed()
        {
            return Magnitude(new List<string> { "км/ч", "м/с", "мили/с" }, "Speed");
        }        

        // Get controller/lenght
        public IActionResult Lenght()
        {
            return Magnitude(new List<string> { "км", "дюйм", "мили" }, "Lenght");
        }

        // Get controller/temperature
        public IActionResult Temperature()
        {
            return Magnitude(new List<string> { "цельсий", "фаренгейт", "кельвин" }, "Temperature");
        }

        // Get controller/weight
        public IActionResult Weight()
        {
            return Magnitude(new List<string> { "кг", "фунты", "пуд" }, "Weight");
        }

    }
}
