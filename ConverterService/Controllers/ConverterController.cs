using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MagnitudeConverter.Models.Magnitude;
using MagnitudeConverter.Logic.Services;
using MagnitudeConverter.Models;

namespace MagnitudeConverter.Controllers
{
    public class ConverterController : Controller
    {
        IService<RequestDto> converterService;
        public ConverterController(IService<RequestDto> service)
        {
            converterService = service;
        }

        
        private IActionResult Magnitude(List<Magnitude> magnitudes)
        {
            ViewBag.Magnitudes = magnitudes;
            return View("Magnitude");
        }


        [HttpPost]
        public IActionResult Result(RequestDto requestDto)
        {
            double value;
            if (ModelState.IsValid && double.TryParse(requestDto.EnteredStringValue, out value))
            {
                requestDto.EnteredValue = value;
                converterService.DoService(requestDto);
                
                ViewBag.RequestDto = requestDto;
                return View();
            }
            else
            {
                return new BadRequestResult();
            }
        }


        //--------------------Speed--------------------
        [HttpGet]
        public IActionResult Speed()
        {
            return Magnitude(new MagnitudeCollection().GetCollectionByMagnitude("speed"));
        }



        //--------------------Lenght--------------------
        [HttpGet]
        public IActionResult Lenght()
        {
            return Magnitude(new MagnitudeCollection().GetCollectionByMagnitude("lenght"));
        }



        //--------------------Temperature--------------------
        [HttpGet]
        public IActionResult Temperature()
        {
            return Magnitude(new MagnitudeCollection().GetCollectionByMagnitude("temperature"));
        }



        //--------------------Weight--------------------
        [HttpGet]
        public IActionResult Weight()
        {
            return Magnitude(new MagnitudeCollection().GetCollectionByMagnitude("weight"));
        }
    }
}