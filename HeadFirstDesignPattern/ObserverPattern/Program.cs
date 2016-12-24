using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Logger
{
    public static void Log(string text)
    {
        Console.WriteLine(text);
    }
}

namespace ObserverPattern
{
    // Bridge object between "Weather Station" and "Weather Display"
    public abstract class WeatherData
    {
        public abstract float getTemperature();
        public abstract float getHumidity();
        public abstract float getPressure();
        /*
         * 기상 관측값이 갱신될 때마다
         * 알려주기 위한 메소드
         */
        public void measurementsChanged()
        {
            // Implement here
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
