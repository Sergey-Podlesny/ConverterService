using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Weight
{
    public class Pood : Magnitude
    {
        public Pood() : base("weight", "pood") { }

        public override double ConvertFromSI(double value)
        {
            return value / 16.381;
        }

        public override double ConvertToSI(double value)
        {
            return value * 16.381;
        }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
