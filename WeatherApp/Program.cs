using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Enter a city name:");
        string city = Console.ReadLine();

        WeatherService weatherService = new WeatherService();
        string weather = await weatherService.GetWeatherAsync(city);

        Console.WriteLine(weather);
    }
}
