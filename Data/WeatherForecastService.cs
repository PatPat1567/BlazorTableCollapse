using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTableCollapse.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();

            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                ID = index,
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                WeeklyForecast = Enumerable.Range(1, 7).Select(index => new WeekDayForecast
                {
                    Day = (DayOfWeek)index-1,
                    High = rng.Next(-10, 55),
                    Low = rng.Next(-20, 45)
                }).ToList()
            }).ToArray());
        }
    }
}
