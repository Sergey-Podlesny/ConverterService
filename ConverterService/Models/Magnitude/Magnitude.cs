using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude
{
    public abstract class Magnitude: IConvert<int>, IValid
    {
        public Magnitude(string nameOfMagnitude, string nameOfUnit)
        {
            NameOfMagnitude = nameOfMagnitude;
            NameOfUnit = nameOfUnit;
        }
        public string NameOfMagnitude { get; }
        public string NameOfUnit { get; }

        public abstract int ConvertFromSI(int value);

        public abstract int ConvertToSI(int value);

        public abstract void IsValid();
    }
}
