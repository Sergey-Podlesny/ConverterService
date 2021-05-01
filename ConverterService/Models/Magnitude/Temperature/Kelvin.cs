using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Temperature
{
    public class Kelvin : Magnitude
    {
        public Kelvin() : base("temperature", "kelvin") { }
        public override void ConvertFromSI(int value)
        {
            throw new NotImplementedException();
        }

        public override void ConvertToSI(int value)
        {
            throw new NotImplementedException();
        }
    }
}
