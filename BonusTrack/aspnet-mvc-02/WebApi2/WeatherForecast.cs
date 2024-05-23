using System.Text.Json.Serialization;

namespace WebApi2
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }
        
        //[JsonPropertyName("t")]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
