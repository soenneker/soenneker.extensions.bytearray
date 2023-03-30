using System.Text;

namespace Soenneker.Extensions.ByteArray;

public static class ByteArrayExtension
{
    /// <summary>
    /// Shorthand for Encoding.UTF8.GetString
    /// </summary>
    public static string ToStr(this byte[] value)
    {
        string result = Encoding.UTF8.GetString(value);
        return result;
    }
}