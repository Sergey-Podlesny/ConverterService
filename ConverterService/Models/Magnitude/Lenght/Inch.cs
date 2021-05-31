using MagnitudeConverter.Exceptions;
using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Lenght
{
    public class Inch : Magnitude
    {

        public Inch() : base("lenght", "inch") { }
        public override double ConvertFromSI(double value)
        {
            return value * 39.37;
        }

        public override double ConvertToSI(double value)
        {
            return value / 39.37;
        }

        public override void IsValid(double value)
        {
            if(value < 0)
            {
                throw new ValidException(HttpStatusCode.InternalServerError);
            }
        }
    }
}
