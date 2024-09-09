using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Text;

namespace Soenneker.Extensions.ByteArray;

/// <summary>
/// A collection of various byte array extension methods
/// </summary>
public static class ByteArrayExtension
{
    /// <summary>
    /// Converts the specified byte array to a UTF-8 encoded string.
    /// </summary>
    /// <param name="value">The byte array to convert.</param>
    /// <returns>A string representation of the byte array, decoded using UTF-8 encoding.</returns>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToStr(this byte[] value)
    {
        return Encoding.UTF8.GetString(value);
    }

    /// <summary>
    /// Converts the specified byte array to a hexadecimal string representation.
    /// </summary>
    /// <param name="value">The byte array to convert.</param>
    /// <returns>A string containing the hexadecimal representation of the byte array.
    /// If the array is empty, an empty string is returned.</returns>
    [Pure]
    public static string ToHex(this byte[] value)
    {
        if (value.Length == 0)
            return "";

        var hex = new StringBuilder(value.Length * 2);

        foreach (byte b in value)
        {
            hex.Append(b.ToString("x2"));
        }

        return hex.ToString();
    }
}