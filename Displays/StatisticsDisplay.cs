using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : DisplayType
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;

        public StatisticsDisplay(Subject weatherData) : base(weatherData) { }

        public override void Display()
        {
            countUpdated++;
            sumTemperature = maxTemp + minTemp;
            Console.WriteLine($"average: {sumTemperature / countUpdated} " +
                $"max: {maxTemp} " +
                $"min: {minTemp} ");
            // Print the average, maximum and minimum temperature. Use appropriate fields
        }
    }
}
