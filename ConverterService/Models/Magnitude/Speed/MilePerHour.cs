using MagnitudeConverter.Exceptions;
using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Speed
{
    public class MilePerHour : Magnitude
    {
        public MilePerHour() : base("speed", "milePerHour") { }

        public override double ConvertFromSI(double value)
        {
            return value * 2.237;
        }

        public override double ConvertToSI(double value)
        {
            return value / 2.237;
        }

        public override void IsValid(double value)
        {
            if (value < 0)
            {
                throw new ValidException(HttpStatusCode.InternalServerError);
            }
        }
    }
}
