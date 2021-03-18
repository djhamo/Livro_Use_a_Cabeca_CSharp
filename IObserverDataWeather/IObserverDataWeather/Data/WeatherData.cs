using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObserverDataWeather.Data
{
    public class WeatherData : IObservable<WeatherData>
    {
        private float temperature;
        public float Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                Notify();
            }
        }
        private float humidity;
        public float Humidity
        {
            get { return humidity; }
            set
            {
                humidity = value;
                Notify();
            }
        }
        private float pressure;
        public float Pressure
        {
            get { return pressure; }
            set
            {
                pressure = value;
                Notify();
            }
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Notify();
        }

                // List of observers and the instance of subject
        private List<IObserver<WeatherData>> _subjectObservers =
            new List<IObserver<WeatherData>>();

        // This method allows the observers to attach themselves. It returns a disposer object to the observer
        // which the observer can utilize to unsubscribe
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_subjectObservers.Contains(observer))
            {
                _subjectObservers.Add(observer);
            }

            return new Disposer(_subjectObservers, observer);
        }

        // This method is used to inspect the subject over time. Usually used with a timer or an event
        public void Notify()
        {
            foreach (IObserver<WeatherData> observer in _subjectObservers)
            {
                observer.OnNext(this);
            }
        }

        //
        // Private class Disposer: Implements the IDisposable. Observable returns an instance to the observer for easy unsubscription
        //
        private class Disposer : IDisposable
        {
            // The observers list recieved from the observable
            private List<IObserver<WeatherData>> _subjectObservers;
            // The observer instance to unsubscribe
            private IObserver<WeatherData> _observer;

            public Disposer(List<IObserver<WeatherData>> _subObservers, IObserver<WeatherData> observer)
            {
                _subjectObservers = _subObservers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_subjectObservers.Contains(_observer))
                {
                    _subjectObservers.Remove(_observer);
                }
            }
        }

    }
}
