using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : DisplayType
    {
        public ForecastDisplay(Subject weatherData) : base(weatherData){ }
    
        public override void Display()
        {
            if (this.temperature < 0)
            {
                Console.WriteLine("it is freezing outside");
            }
            else if (this.temperature < 10)
            {
                Console.WriteLine("it is cold outside");
            }
            else if (this.temperature > 10 && this.temperature < 20)
            {
                Console.WriteLine("it is moderate outside");
            }
            else if (this.temperature > 20) {
                Console.WriteLine("it is hot outside");
            }
        }
    }
}
