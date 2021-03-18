using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObserverDataWeather.Observer;
using IObserverDataWeather.Data;

namespace IObserverDataWeather.Display
{
    public class CurrentCondition : IObserver<WeatherData>, DisplayElement
    {
        private float temperature;
        private float humidity;
        private IDisposable _disposer;

        public CurrentCondition(IObservable<WeatherData> weatherData)
        {
            _disposer = weatherData.Subscribe(this);
        }

        public void OnNext(WeatherData value)
        {
            this.temperature = value.Temperature;
            this.humidity = value.Humidity;
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


        public void display()
        {
            Console.WriteLine("Current condition: {0} F degrees and {1} humidity", temperature, humidity);
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}
