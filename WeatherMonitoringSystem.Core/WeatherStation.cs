using System;

namespace WeatherMonitoringSystem.Core
{
    /// <summary>
    /// Factory class for creating different types of displays.
    /// </summary>
    public class WeatherStation
    {
        /// <summary>
        /// Creates a display of the specified type.
        /// </summary>
        /// <param name="displayType">The type of display to create.</param>
        /// <returns>An instance of the specified display type.</returns>
        public IDisplay CreateDisplay(string displayType)
        {
            switch (displayType.ToLower())
            {
                case "current":
                    return new CurrentConditionsDisplay();
                case "statistics":
                    return new StatisticsDisplay();
                case "forecast":
                    return new ForecastDisplay();
                default:
                    throw new ArgumentException("Invalid display type.");
            }
        }
    }
}