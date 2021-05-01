using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagnitudeConverter.Models.Magnitude.Lenght;
using MagnitudeConverter.Models.Magnitude.Speed;
using MagnitudeConverter.Models.Magnitude.Temperature;
using MagnitudeConverter.Models.Magnitude.Weight;

namespace MagnitudeConverter.Models.Magnitude
{
    public class MagnitudeCollection
    {

        List<Magnitude> magnitudes;

        public MagnitudeCollection()
        {
            magnitudes = new List<Magnitude>
            {
                new Inch(),
                new Kilometer(),
                new Mile(),

                new KilometerPerHour(),
                new MeterPerSecond(),
                new MilePerHour(),

                new Celsius(),
                new Fahrenheit(),
                new Kelvin(),

                new Kilogram(),
                new Pood(),
                new Pound()
            };

        }

        public List<Magnitude> GetCollectionByMagnitude(string key)
        {
            return magnitudes.Where(m => m.NameOfMagnitude.ToLower() == key.ToLower()).ToList();
        }

        public Magnitude GetMagnitudeByUnit(string key)
        {
            return magnitudes.Where(m => m.NameOfUnit.ToLower() == key.ToLower()).First();
        }
    }
}
