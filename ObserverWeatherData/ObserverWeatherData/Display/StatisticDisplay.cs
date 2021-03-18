using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverWeatherData.Interfaces;

namespace ObserverWeatherData.Display
{
    class StatisticDisplay : Observer, DisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;

        public StatisticDisplay(Subject weather)
        {
            weather.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;

            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                minTemp = temperature;
            }

            display();
        }

        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature: {0}/{1}/{2}", (tempSum / numReadings), maxTemp, minTemp);
        }
    }
}
