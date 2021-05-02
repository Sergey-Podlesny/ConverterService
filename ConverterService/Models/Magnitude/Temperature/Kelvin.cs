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

        public override int ConvertFromSI(int value)
        {
            return value;
        }

        public override int ConvertToSI(int value)
        {
            return value;
        }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
