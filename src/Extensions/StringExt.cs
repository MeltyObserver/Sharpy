namespace Sharpy.Extensions;

public static class StringExt
{
    public static string ToTitle(this string text)
    {
        // needs more work
        return text[0].ToString().ToUpper() + text[1..];
    }
}