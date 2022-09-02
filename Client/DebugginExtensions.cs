using System.Text.Json;

namespace DeveloperPlace.Client;

public static class DebugginExtensions
{
    private static JsonSerializerOptions options = new JsonSerializerOptions
    {
        WriteIndented = true
    };

    public static string toJson(this object obj, JsonSerializerOptions options) =>
        JsonSerializer.Serialize(obj, options);

}