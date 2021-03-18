using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObserverDataWeather.Observer;
using IObserverDataWeather.Data;

namespace IObserverDataWeather.Display
{
    class StatisticDisplay : IObserver<WeatherData>, DisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;

        private IDisposable _disposer;

        public StatisticDisplay(IObservable<WeatherData> weatherData)
        {
            _disposer = weatherData.Subscribe(this);
        }

        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature: {0}/{1}/{2}", (tempSum / numReadings), maxTemp, minTemp);
        }

        public void OnNext(WeatherData value)
        {
            float temperature = value.Temperature;
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

        // Usually called when a transmission is complete. Not implemented.
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        // Usually called when there was an error. Didn't implement.
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

    }
}
