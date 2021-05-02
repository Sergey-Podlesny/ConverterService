using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Lenght
{
    public class Mile : Magnitude
    {
        public Mile() : base("lenght", "mile") { }

        public override double ConvertFromSI(double value)
        {
            return value / 1609;
        }

        public override double ConvertToSI(double value)
        {
            return value * 1609;
        }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
