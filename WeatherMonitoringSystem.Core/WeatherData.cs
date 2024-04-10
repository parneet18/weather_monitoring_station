using System;
using System.Collections.Generic;

namespace WeatherMonitoringSystem.Core
{
    /// <summary>
    /// Singleton class responsible for managing weather data and notifying observers.
    /// </summary>
    public sealed class WeatherData
    {
        // Singleton implementation
        private static readonly WeatherData instance = new WeatherData();

        /// <summary>
        /// Private constructor to prevent instantiation outside of the class.
        /// </summary>
        private WeatherData() { }

        /// <summary>
        /// Gets the singleton instance of WeatherData.
        /// </summary>
        public static WeatherData Instance => instance;

        // Observer pattern implementation
        private List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// Registers an observer to receive weather updates.
        /// </summary>
        /// <param name="observer">The observer to register.</param>
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Removes an observer from the list of subscribers.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all registered observers when weather data changes.
        /// </summary>
        /// <param name="temperature">The new temperature value.</param>
        /// <param name="humidity">The new humidity value.</param>
        /// <param name="pressure">The new pressure value.</param>
        public void NotifyObservers(float temperature, float humidity, float pressure)
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        /// <summary>
        /// Simulates updating weather measurements and notifies observers.
        /// </summary>
        /// <param name="temperature">The new temperature value.</param>
        /// <param name="humidity">The new humidity value.</param>
        /// <param name="pressure">The new pressure value.</param>
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            // Simulate data change
            // In a real application, this method would receive actual data from a weather station
            Console.WriteLine("Weather data updated:");
            Console.WriteLine($"Temperature: {temperature} C, Humidity: {humidity}%, Pressure: {pressure} hPa");
            Console.WriteLine();

            // Notify observers
            NotifyObservers(temperature, humidity, pressure);
        }
    }
}
