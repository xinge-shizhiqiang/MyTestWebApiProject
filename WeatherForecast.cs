using System.ComponentModel.DataAnnotations;

namespace MyTestWebApiProject
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        //[StringLength(1)]
        public string? Summary { get; set; }
    }
}