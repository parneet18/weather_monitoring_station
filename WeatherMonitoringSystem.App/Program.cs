using System;

namespace WeatherMonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Weather Station
            var weatherStation = new WeatherMonitoringSystem.Core.WeatherStation();

            // Create displays using the factory pattern
            var currentDisplay = (WeatherMonitoringSystem.Core.CurrentConditionsDisplay)weatherStation.CreateDisplay("current");
            var statisticsDisplay = (WeatherMonitoringSystem.Core.StatisticsDisplay)weatherStation.CreateDisplay("statistics");
            var forecastDisplay = (WeatherMonitoringSystem.Core.ForecastDisplay)weatherStation.CreateDisplay("forecast");

            // Simulate initial weather data
            Random random = new Random();
            float temperature = random.Next(0, 50);
            float humidity = random.Next(0, 100);
            float pressure = random.Next(950, 1050);

            // Update displays with initial weather data
            currentDisplay.Update(temperature, humidity, pressure);
            statisticsDisplay.Update(temperature, humidity, pressure);
            forecastDisplay.Update(temperature, humidity, pressure);

            // Display current weather data on all displays
            currentDisplay.Display();
            statisticsDisplay.Display();
            forecastDisplay.Display();

            // Simulate weather data changes and update displays
            for (int i = 0; i < 5; i++)
            {
                // Simulate new weather data
                temperature = random.Next(0, 50);
                humidity = random.Next(0, 100);
                pressure = random.Next(950, 1050);

                // Update displays with new weather data
                currentDisplay.Update(temperature, humidity, pressure);
                statisticsDisplay.Update(temperature, humidity, pressure);
                forecastDisplay.Update(temperature, humidity, pressure);

                // Display current weather data on all displays
                currentDisplay.Display();
                statisticsDisplay.Display();
                forecastDisplay.Display();

                // Pause before updating weather data again
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
