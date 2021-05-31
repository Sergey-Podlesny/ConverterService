using MagnitudeConverter.Exceptions;
using MagnitudeConverter.Logic.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Speed
{
    public class KilometerPerHour : Magnitude
    {
        public KilometerPerHour() : base("speed", "kilometerPerHour") { }

        public override double ConvertFromSI(double value)
        {
            return value * 3.6;
        }

        public override double ConvertToSI(double value)
        {
            return value / 3.6;
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
