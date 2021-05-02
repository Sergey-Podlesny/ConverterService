using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Logic.Converter
{
    interface IConvert<T>
    {
        T ConvertToSI(T value);
        T ConvertFromSI(T value);
    }
}
