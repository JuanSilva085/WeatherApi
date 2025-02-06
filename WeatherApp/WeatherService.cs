using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class WeatherService
{
    private static readonly HttpClient client = new HttpClient();
    private string apiKey = "e9279aaba245027a7389669746413696";

    public async Task<string> GetWeatherAsync(string city)
    {
        try
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JObject weatherData = JObject.Parse(responseBody);
            string description = weatherData["weather"][0]["description"].ToString();
            string temp = weatherData["main"]["temp"].ToString();

            return $"Current weather in {city}: {description}, {temp}°C";
        }
        catch (Exception e)
        {
            return $"Error: {e.Message}";
        }
    }
}
