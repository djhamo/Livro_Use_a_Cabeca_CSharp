using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverWeatherData.Interfaces
{
    public interface Observer
    {
        void update(float temp, float humidity, float pressure);
    }
}
