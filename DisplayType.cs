using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal abstract class DisplayType: Observer
    {
        protected Subject weatherData;

        protected float temperature;
        protected float humidity;
        protected float pressure;

        public DisplayType(Subject weather)
        {
            this.weatherData = weather;
            weather.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure= pressure;
            Display();
        }

        public abstract void Display();
    }
}
