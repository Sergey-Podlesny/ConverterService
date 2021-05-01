using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Lenght
{
    public class Kilometer : Magnitude
    {
        public Kilometer() : base("lenght", "kilometer") { }
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
