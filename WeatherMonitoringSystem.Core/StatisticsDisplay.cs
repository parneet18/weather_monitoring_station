using System;

namespace WeatherMonitoringSystem.Core
{
    /// <summary>
    /// Concrete display class representing weather statistics.
    /// Implements the Observer pattern.
    /// </summary>
    public class StatisticsDisplay : IDisplay, IObserver
    {
        /// <summary>
        /// Displays the weather statistics including average, max, and min temperatures.
        /// </summary>
        public void Display()
        {
            // Display weather statistics including average, max, and min temperatures
            Console.WriteLine("Weather statistics: Average, Max, and Min Temperatures");
        }

        /// <summary>
        /// Updates the display with new weather data.
        /// </summary>
        /// <param name="temperature">The new temperature value.</param>
        /// <param name="humidity">The new humidity value.</param>
        /// <param name="pressure">The new pressure value.</param>
        public void Update(float temperature, float humidity, float pressure)
        {
            // Update display with new weather data
            Console.WriteLine($"Statistics updated: Temperature: {temperature}, Humidity: {humidity}, Pressure: {pressure}");
        }
    }
}
