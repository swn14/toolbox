using System.Text.Json;

namespace CsharpToolbox;
public static class ByteArrayHelpers
{
    /// <summary>
    /// Converts any object to a byte array
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>byte[]</returns>
    public static byte[] ToByteArray(this Object obj) => JsonSerializer.SerializeToUtf8Bytes(obj);

    /// <summary>
    /// Converts a byte array to the given type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="options"></param>
    /// <returns>T</returns>
    public static T? FromByteArray<T>(byte[] data, JsonSerializerOptions? options = null)
    {
        var jsonUtfReader = new ReadOnlySpan<byte>(data);
        return JsonSerializer.Deserialize<T>(jsonUtfReader, options ?? JsonHelpers.JsonSerializerOptions);
    }
}