using Api.Entities;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.WindowsClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetIp();

            System.Threading.Thread.Sleep(5000);

            var forecast = GetWeatherForecastAsync(new Zone
            {
                City = "Acapulco",
                Date = new DateTime(2021, 10, 20)
            }).Result;

            Console.WriteLine("Ciudad:" + forecast.Zone.City);
            Console.WriteLine("Fecha:" + forecast.Zone.Date);

            foreach(var item in forecast.WeatherForecast)
            {
                Console.WriteLine();
                Console.WriteLine("Summary:" + item.Summary);
                Console.WriteLine("TemperaturaC:" + item.TemperatureC);
                Console.WriteLine("TemperaturaC:" + item.TemperatureF);
            }

            Console.ReadKey();
        }

        private static async Task<ZoneWeatherForecast> GetWeatherForecastAsync(Zone zone)
        {
            string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(zone);

            HttpClient client = new HttpClient();



            HttpResponseMessage response = await client.PostAsync("https://localhost:44345/weatherforecast/byzone", new StringContent(jsonContent, Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            ZoneWeatherForecast forecast = Newtonsoft.Json.JsonConvert.DeserializeObject<ZoneWeatherForecast>(responseBody);

            //Console.WriteLine("My current Ip Address is: " + ip.Ip);

            //var info = await GetIpInfo(ip.Ip);

            //Console.WriteLine("Country: " + info.Country);
            //Console.WriteLine("City: " + info.City);
            //Console.WriteLine("Timezone: " + info.TimeZone);

            return forecast;
        }

        private static async Task<IpAddress> GetIp()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://api.ipify.org/?format=json");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            IpAddress ip = Newtonsoft.Json.JsonConvert.DeserializeObject<IpAddress>(responseBody);

            Console.WriteLine("My current Ip Address is: " + ip.Ip);

            var info = await GetIpInfo(ip.Ip);

            Console.WriteLine("Country: " + info.Country);
            Console.WriteLine("City: " + info.City);
            Console.WriteLine("Timezone: " + info.TimeZone);

            return ip;
        }

        private static async Task<IpInfo> GetIpInfo(string ipAddress)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://ipinfo.io/{ipAddress}/geo");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            IpInfo info = Newtonsoft.Json.JsonConvert.DeserializeObject<IpInfo>(responseBody);

            return info;
        }
    }
}
