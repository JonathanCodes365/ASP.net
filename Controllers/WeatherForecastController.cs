using Microsoft.AspNetCore.Mvc;

namespace CRUD_APP1.Controllers;

[ApiController]
//this line tells ASP.net to treat this class as an API controller.
[Route("[controller]")]
//this is telling controller is replaced by controller's name without Controller.
//example in this we have WeatherForecastController.cs removes Controller and goes to WeatherForecast.

//so later when we call something like ProductsController it will call Products

public class WeatherForecastController : ControllerBase
//this particular code is our controller.
//A controller is the place where we define what our API does when it receives HTTP requests.
{
    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    [HttpGet(Name = "GetWeatherForecast")]
    //so this is an endpoint saying:
    //if a Get Request comes to this controller, execute thhis method.
    public IEnumerable<WeatherForecast> Get()
    //IEnmuerable <WeatherForecast> returns collection of WeatherForecast objects.
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
        //converts toarray.
    }
}
