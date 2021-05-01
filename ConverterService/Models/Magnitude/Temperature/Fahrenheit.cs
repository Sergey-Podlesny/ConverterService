using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Temperature
{
    public class Fahrenheit : Magnitude
    {
        public Fahrenheit() : base("temperature", "fahrenheit") { }
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
