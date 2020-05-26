using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTableCollapse.Data
{
    public class WeekDayForecast
    {
        public DayOfWeek Day { get; set; }
        public int High { get; set; }
        public int Low { get; set; }
    }

}
