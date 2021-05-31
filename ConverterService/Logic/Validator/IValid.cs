using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Logic.Validator
{
    interface IValid<T>
    {
        void IsValid(T value);
    }
}
