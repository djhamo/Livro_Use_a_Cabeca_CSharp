using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverWeatherData.Interfaces;

namespace ObserverWeatherData.Data
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        public float Temperature
        {
            get { return temperature; } 
            set 
            {
                temperature = value;
                measurementChanged();

            } 
        }
        private float humidity;
        public float Humidity
        {
            get { return humidity; }
            set
            {
                humidity = value;
                measurementChanged();

            }
        }
        private float pressure;
        public float Pressure
        {
            get { return pressure; }
            set
            {
                pressure = value;
                measurementChanged();

            }
        }

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (Observer ob in observers)
            {
                ob.update(Temperature, Humidity, Pressure);
            }
        }

        public void measurementChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementChanged();
        }
    }
}
