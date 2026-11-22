using ClosetCastMVC.Models;

namespace ClosetCastMVC.Services
{
    public interface INOAAWeatherService
    {
        Task<WeatherData> GetWeatherAsync(string city);
    }
}
