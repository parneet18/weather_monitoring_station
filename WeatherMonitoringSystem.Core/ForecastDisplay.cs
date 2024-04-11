using System;

namespace WeatherMonitoringSystem.Core
{
    /// <summary>
    /// Concrete display class representing a weather forecast.
    /// Implements the Observer pattern.
    /// </summary>
    public class ForecastDisplay : IDisplay, IObserver
    {
        private float currentTemperature;

        /// <summary>
        /// Displays the weather forecast based on the current weather data.
        /// </summary>
        public void Display()
        {
            // Display weather forecast based on current temperature
            if (currentTemperature > 25)
            {
                Console.WriteLine("Weather forecast: Hot and sunny");
            }
            else if (currentTemperature < 5)
            {
                Console.WriteLine("Weather forecast: Cold with snow");
            }
            else
            {
                Console.WriteLine("Weather forecast: Mild with a chance of rain");
            }
        }

        /// <summary>
        /// Updates the display with new weather data.
        /// </summary>
        /// <param name="temperature">The new temperature value.</param>
        /// <param name="humidity">The new humidity value.</param>
        /// <param name="pressure">The new pressure value.</param>
        public void Update(float temperature, float humidity, float pressure)
        {
            // Store current temperature
            currentTemperature = temperature;

            // Update display with new weather data
            Console.WriteLine($"Forecast updated: Temperature: {temperature}, Humidity: {humidity}, Pressure: {pressure}");
        }
    }
}
