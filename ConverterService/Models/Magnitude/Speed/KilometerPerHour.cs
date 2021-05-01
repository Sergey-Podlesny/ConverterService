using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Speed
{
    public class KilometerPerHour : Magnitude
    {
        public KilometerPerHour() : base("speed", "kilometerPerHour") { }
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
