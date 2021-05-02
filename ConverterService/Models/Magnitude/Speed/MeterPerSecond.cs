using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Speed
{
    public class MeterPerSecond : Magnitude
    {
        public MeterPerSecond() : base("speed", "meterPerSecond") { }

        public override double ConvertFromSI(double value)
        {
            return value;
        }

        public override double ConvertToSI(double value)
        {
            return value;
        }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
