using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BasicRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            var rng = new Random();
            return new List<WeatherForecast>
            {
                new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(1),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = "Warm",
                    Precipitation = rng.Next(0, 100)
                },
                new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(2),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = "Cold",
                    Precipitation = rng.Next(0, 100)
                },
                new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(3),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = "Mild",
                    Precipitation = rng.Next(0, 100)
                }
            };
        }
    }
}