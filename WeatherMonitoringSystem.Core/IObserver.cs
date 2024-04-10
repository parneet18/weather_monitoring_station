
namespace WeatherMonitoringSystem.Core
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
