using System.Text.Json;

namespace DeveloperPlace.Client;

public static class DebugginExtensions
{
    private static JsonSerializerOptions options = new JsonSerializerOptions
    {
        WriteIndented = true
    };

    public static string ToJson(this object obj) =>
        JsonSerializer.Serialize(obj, options);

}