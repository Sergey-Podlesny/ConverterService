using MagnitudeConverter.Models.Magnitude.Lenght;
using MagnitudeConverter.Models.Magnitude;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagnitudeConverter.Models;

namespace MagnitudeConverter.Logic.Services
{
    public class ConverterService : IService<RequestDto>
    {

        Magnitude fromMagnitude;
        Magnitude toMagnitude;

        public void DoService(RequestDto requestDto)
        {
            SetMagnitude(requestDto.FromUnit, requestDto.ToUnit);

            //todo ChekValid();

            //fromMagnitude.ConvertToSI(requestDto.Value);
            //toMagnitude.ConvertFromSI(requestDto.Value);
            throw new NotImplementedException();
        }

        private void SetMagnitude(string fromUnit, string toUnit)
        {
            fromMagnitude = new MagnitudeCollection().GetMagnitudeByUnit(fromUnit);
            toMagnitude = new MagnitudeCollection().GetMagnitudeByUnit(toUnit);
        }
    }
}
