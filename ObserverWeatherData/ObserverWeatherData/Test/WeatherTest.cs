using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverWeatherData.Data;
using ObserverWeatherData.Display;

namespace ObserverWeatherData.Test
{
    [TestClass]
    public class WeatherTest
    {
        [TestMethod]
        public void CurrentDisplayTest()
        {
            WeatherData weatherdata = new WeatherData();
            CurrentConditionDisplay currentDisplay = 
                new CurrentConditionDisplay(weatherdata);

            StatisticDisplay statDisplay = new StatisticDisplay(weatherdata);

            weatherdata.setMeasurements(80f, 65f, 30.4f);
            weatherdata.setMeasurements(82f, 70f, 29.2f);
            weatherdata.setMeasurements(78f, 90f, 29.2f);


        }
    }
}
