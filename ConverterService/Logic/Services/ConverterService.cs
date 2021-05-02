using MagnitudeConverter.Models.Magnitude.Lenght;
using MagnitudeConverter.Models.Magnitude;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagnitudeConverter.Models;
using MagnitudeConverter.Logic.Converter;
using MagnitudeConverter.Logic.Validator;

namespace MagnitudeConverter.Logic.Services
{
    public class ConverterService : IService<RequestDto>
    {
        public void DoService(RequestDto requestDto)
        {
            Magnitude fromMagnitude = GetMagnitude(requestDto.FromUnit);
            Magnitude toMagnitude = GetMagnitude(requestDto.ToUnit);
            //CheckValid(fromMagnitude);
            //CheckValid(toMagnitude);
            Convert(fromMagnitude, toMagnitude, requestDto);
        }

        private Magnitude GetMagnitude(string unit)
        {
            return new MagnitudeCollection().GetMagnitudeByUnit(unit);
        }

        private void CheckValid(IValid unit)
        {
            unit.IsValid();
        }

        private void Convert(IConvert<double> fromUnit, IConvert<double> toUnit, RequestDto dto)
        {
            double siValue = fromUnit.ConvertToSI(dto.EnteredValue);
            double resValue = toUnit.ConvertFromSI(siValue);
            dto.ResultValue = Math.Round(resValue, 3);
        }
    }
}
