using Microsoft.AspNetCore.Mvc;

namespace WebApiTeste.Controllers;

[ApiController]
[Route("[Controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet()]
    [Route("GetCustomizado/")]
    public string GetCustomizado([FromQuery] string p_nome, [FromQuery] int p_idade)
    {
        return $"Customizei. nome{p_nome}, Idade: {p_idade}";
    }

    [HttpGet()]
    [Route("GetObjetoDinamico/")]
    public List<Dictionary<string, object>> GetObjetoDinamico()
    {
        return new List<Dictionary<string, object>>{
            new Dictionary<string, object>{
                {"nome", "Vinicius"},
                {"idade", 24}
            }
        };
    }
}