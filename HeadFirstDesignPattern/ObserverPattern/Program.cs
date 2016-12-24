using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Logger
{
    public static void Log(string format, object arg0, object arg1, object arg2)
    {
        Console.WriteLine(format, arg0, arg1, arg2);
    }
}

namespace ObserverPattern
{
    // Bridge object between "Weather Station" and "Weather Display"
    public class WeatherData
    {
        public WeatherData()
        {
            conditionDisplay = new ConditionDisplay();
            statisticsDisplay = new StatisticsDisplay();
            forecastDisplay = new ForecastDisplay();
        }

        public ConditionDisplay conditionDisplay;
        public StatisticsDisplay statisticsDisplay;
        public ForecastDisplay forecastDisplay;

        public float getTemperature()
        {
            return 62f;
        }
        public float getHumidity()
        {
            return 50f;
        }
        public float getPressure()
        {
            return 78f;
        }
        /*
         * 기상 관측값이 갱신될 때마다
         * 알려주기 위한 메소드
         */
        public void measurementsChanged()
        {
            var temp = getTemperature();
            var humidity = getHumidity();
            var pressure = getPressure();

            conditionDisplay.Update(temp, humidity, pressure);
            statisticsDisplay.Update(temp, humidity, pressure);
            forecastDisplay.Update(temp, humidity, pressure);
        }
    }

    interface WeatherDisplay
    {
        void Update(float temp, float humidity, float pressure);
    }

    public class ConditionDisplay : WeatherDisplay
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Logger.Log("Display 현재 조건: {0}, {1}, {2}", temp, humidity, pressure);
        }
    }

    public class StatisticsDisplay : WeatherDisplay
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Logger.Log("Display 기상 통계: {0}, {1}, {2}", temp, humidity, pressure);
        }
    }

    public class ForecastDisplay : WeatherDisplay
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Logger.Log("Display 기상 예측: {0}, {1}, {2}", temp, humidity, pressure);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var wd = new WeatherData();
            wd.measurementsChanged();
        }
    }
}
