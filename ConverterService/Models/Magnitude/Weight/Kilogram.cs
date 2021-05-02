﻿using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models.Magnitude.Weight
{
    public class Kilogram : Magnitude
    {
        public Kilogram() : base("weight", "kilogram") { }

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
