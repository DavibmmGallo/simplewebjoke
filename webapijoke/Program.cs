using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using webapijoke.classes;

namespace webapijoke
{
    class Program
    {
        static void Main(string[] args)
        {
            mainthread();
            
        }
        static async void mainthread()
        {
            HttpClient httpClient = new HttpClient();

            string url = $"https://sv443.net/jokeapi/v2/joke/Any?blacklistFlags=nsfw,religious,political,racist,sexist&type=single";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            HttpResponseMessage response = httpClient.SendAsync(request).Result;
            string dados = await response.Content.ReadAsStringAsync();

            Joke myjoke = JsonConvert.DeserializeObject<Joke>(dados);

            myjoke.Show();

            char c = '0';
            Console.Write("\nDo you like this joke, save it! (y/n) : ");
            char.TryParse(Console.ReadLine(), out c);
            if (char.ToLower(c) == 'y')
            {
                using (StreamWriter json = File.CreateText(Directory.GetCurrentDirectory().Replace("\\netcoreapp3.1","")+$"\\joke_{myjoke.id}.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(json, myjoke);
                }
                Console.WriteLine($"Saved at {Directory.GetCurrentDirectory().Replace("\\netcoreapp3.1", "") + $"\\{myjoke.id}.json"}");
            }                
        }
    }
}
