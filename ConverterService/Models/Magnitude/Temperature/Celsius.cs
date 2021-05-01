using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Temperature
{
    public class Celsius : Magnitude
    {
        public Celsius() : base("temperature", "celsius") { }
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
