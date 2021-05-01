using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude
{
    public abstract class Magnitude
    {
        public Magnitude(string nameOfMagnitude, string nameOfUnit)
        {
            NameOfMagnitude = nameOfMagnitude;
            NameOfUnit = nameOfUnit;
        }
        public string NameOfMagnitude { get; }
        public string NameOfUnit { get; }
        public abstract void ConvertFromSI(int value);
        public abstract void ConvertToSI(int value);
    }
}
