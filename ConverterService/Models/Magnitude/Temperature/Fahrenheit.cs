using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Temperature
{
    public class Fahrenheit : Magnitude
    {
        public Fahrenheit() : base("temperature", "fahrenheit") { }

        public override double ConvertFromSI(double value)
        {
            return (value * 1.8) + 32;
        }

        public override double ConvertToSI(double value)
        {
            return (value - 32) / 1.8;
        }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
