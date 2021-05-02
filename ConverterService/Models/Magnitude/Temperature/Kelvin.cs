using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Temperature
{
    public class Kelvin : Magnitude
    {
        public Kelvin() : base("temperature", "kelvin") { }

        public override double ConvertFromSI(double value)
        {
            return value + 273.15;
        }

        public override double ConvertToSI(double value)
        {
            return value - 273.15;
        }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
