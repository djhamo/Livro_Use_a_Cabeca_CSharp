using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IObserverDataWeather.Data;
using IObserverDataWeather.Display;
using IObserverDataWeather.Observer;

namespace IObserverDataWeather.Test
{
    [TestClass]
    public class TestIObserver
    {
        [TestMethod]
        public void BasicObserver()
        {
            WeatherData wd = new WeatherData();
            CurrentCondition currentDisplay = new CurrentCondition(wd);

            wd.setMeasurements(80f, 65f, 30.4f);
            wd.setMeasurements(82f, 70f, 29.2f);
            wd.setMeasurements(78f, 90f, 29.2f);
        }

        [TestMethod]
        public void CompleteObserver()
        {
            WeatherData wd = new WeatherData();
            CurrentCondition currentDisplay = new CurrentCondition(wd);
            StatisticDisplay stDisplay = new StatisticDisplay(wd);

            wd.setMeasurements(80f, 65f, 30.4f);
            wd.setMeasurements(82f, 70f, 29.2f);
            wd.setMeasurements(78f, 90f, 29.2f);
        }
    }
}
