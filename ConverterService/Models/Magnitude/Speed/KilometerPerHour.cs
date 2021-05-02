using MagnitudeConverter.Logic.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Speed
{
    public class KilometerPerHour : Magnitude
    {
        public KilometerPerHour() : base("speed", "kilometerPerHour") { }

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
