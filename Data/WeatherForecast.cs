using System;
using System.Collections.Generic;

namespace BlazorTableCollapse.Data
{
    public class WeatherForecast
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public List<WeekDayForecast> WeeklyForecast { get; set; }
    }
}
