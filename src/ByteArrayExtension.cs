using System;
using System.Diagnostics.Contracts;
using System.Text;

namespace Soenneker.Extensions.ByteArray;

/// <summary>
/// A collection of various byte array extension methods
/// </summary>
public static class ByteArrayExtension
{
    /// <summary>
    /// Shorthand for <code>Encoding.UTF8.GetString</code>
    /// </summary>
    [Pure]
    public static string ToStr(this byte[] value)
    {
        string result = Encoding.UTF8.GetString(value);
        return result;
    }

    [Pure]
    public static string ToHex(this byte[] value)
    {
        string result = BitConverter.ToString(value).Replace("-", "");
        return result;
    }
}