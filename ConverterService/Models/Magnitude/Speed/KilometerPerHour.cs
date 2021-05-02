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

        public override double ConvertFromSI(double value)
        {
            return value * 3.6;
        }

        public override double ConvertToSI(double value)
        {
            return value / 3.6;
        }
        public override void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
