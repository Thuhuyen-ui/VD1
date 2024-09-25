using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("hay nhap dia chi IP: ");
        string ipAddress = Console.ReadLine();
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, $"http://ipinfo.io/{ipAddress}/geo");
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        Console.WriteLine(await response.Content.ReadAsStringAsync());
    }
}
