using System;

namespace WeatherMonitoringSystem.Core
{
    /// <summary>
    /// Concrete display class that shows current weather conditions and optionally decorates another display.
    /// Implements both the Observer and Decorator patterns.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay, IObserver
    {
        private readonly IDisplay decoratedDisplay;

        /// <summary>
        /// Constructor to initialize the CurrentConditionsDisplay with an optional decorated display.
        /// </summary>
        /// <param name="decoratedDisplay">Optional decorated display to add additional information.</param>
        public CurrentConditionsDisplay(IDisplay decoratedDisplay = null)
        {
            this.decoratedDisplay = decoratedDisplay;
        }

        /// <summary>
        /// Displays the current weather conditions.
        /// </summary>
        public void Display()
        {
            // Display current weather conditions
            Console.WriteLine("Current weather conditions:");
            if (decoratedDisplay != null)
            {
                decoratedDisplay.Display(); // Display additional information if available
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
            // Update display with new weather data
            Console.WriteLine($"Temperature: {temperature} C, Humidity: {humidity}%, Pressure: {pressure} hPa");
        }
    }
}
