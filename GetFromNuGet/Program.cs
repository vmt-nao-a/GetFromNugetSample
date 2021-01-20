using System;
using System.Net.Http;
using System.Threading.Tasks;
using Utf8Json;

namespace GetFromNuGet
{
    public class X
    {
        public async Task<string> F()
        {
            var client = new HttpClient();
            //var response = await client.GetAsync(@"https://api.nuget.org/v3/index.json");
            var response = await client.GetAsync(@"https://azuresearch-usnc.nuget.org/query?q=MahApps.Metro");
            return await response.Content.ReadAsStringAsync();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var x = new X();
            var body = x.F();
            body.Wait();
            Console.WriteLine(body.Result);

            var w = JsonSerializer.Deserialize<Welcome>(body.Result);
        }
    }
}
