using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PolyhydraGames.Core.Global.Helpers;

public static class WebHelpers
{
    private static readonly HttpClient Client = new();

    public static Task<string> GetString(string url)
    {
        return Client.GetStringAsync(url);
    }

    public static T FromJson<T>(this string input)
    {
        return JsonSerializer.Deserialize<T>(input);
    }
}
