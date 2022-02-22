using System.Text;
using System.Text.RegularExpressions;

namespace ASCII_To_Shift_JIS_Converter;

internal class ConverterOutput
{
    internal string ShiftJISString { get; set; } = "";
    internal byte[] ShiftJISBytes { get; set; } = Array.Empty<byte>();
}

internal static class AsciiToShiftJISConverter
{
    internal const string shiftJISEncodingName = "shift_jis";

    internal const int amountOfNumbers = 10;
    internal const int amountOfLetters = 26;

    internal const int asciiNumbersIndex = 0x30;
    internal const int asciiUppercaseLettersIndex = 0x41;
    internal const int asciiLowercaseLettersIndex = 0x61;

    internal const int shiftJISNumbersIndex = 0x824f;
    internal const int shiftJISUppercaseLettersIndex = 0x8260;
    internal const int shiftJISLowercaseLettersIndex = 0x8281;

    internal static ConverterOutput Convert(string asciiString)
    {
        var shiftJISString = ConvertAsciiStringToShiftJISString(asciiString);
        return GetConverterOutput(shiftJISString);
    }

    internal static ConverterOutput ConvertExcludingTags(string asciiString)
    {
        var (asciiStringWithoutTags, tagContents) = ParseTags(asciiString);
        var shiftJISStringWithoutTags = ConvertAsciiStringToShiftJISString(asciiStringWithoutTags);
        var shiftJISStringWithTags = PasteTags(shiftJISStringWithoutTags, tagContents);

        return GetConverterOutput(shiftJISStringWithTags);
    }

    private static ConverterOutput GetConverterOutput(string shiftJISString)
    {
        var shiftJISBytes = Encoding.GetEncoding(shiftJISEncodingName).GetBytes(shiftJISString);
        return new ConverterOutput { ShiftJISString = shiftJISString, ShiftJISBytes = shiftJISBytes };
    }

    private static string ConvertAsciiStringToShiftJISString(string asciiString)
    {
        var asciiBytes = asciiString.Select(c => BitConverter.GetBytes(c).First());

        var shiftJISBytes = asciiBytes
            .Select(b => ConvertAsciiByteToShiftJISBytes(b))
            .SelectMany(bytes => BitConverter.GetBytes(bytes).Reverse())  // reversing for little endian
            .Where(b => b != 0)
            .ToArray();

        var shiftJISString = Encoding.GetEncoding(shiftJISEncodingName).GetString(shiftJISBytes);
        return shiftJISString;
    }

    private static int ConvertAsciiByteToShiftJISBytes(byte asciiByte)
    {
        if (asciiByte is >= asciiNumbersIndex and < (asciiNumbersIndex + amountOfNumbers))
            return shiftJISNumbersIndex + (asciiByte - asciiNumbersIndex);

        if (asciiByte is >= asciiUppercaseLettersIndex and < (asciiUppercaseLettersIndex + amountOfLetters))
            return shiftJISUppercaseLettersIndex + (asciiByte - asciiUppercaseLettersIndex);

        if (asciiByte is >= asciiLowercaseLettersIndex and < (asciiLowercaseLettersIndex + amountOfLetters))
            return shiftJISLowercaseLettersIndex + (asciiByte - asciiLowercaseLettersIndex);

        return asciiByte;
    }

    private static (string parsedString, Stack<string> tagContents) ParseTags(string source)
    {
        var tagRegex = new Regex(sourceTagRegex);
        var matches = tagRegex.Matches(source);
        var matchesValues = matches.Select(m => m.Value).Reverse();

        var parsedString = tagRegex.Replace(source, placeholderTag);
        var matchesStack = new Stack<string>(matchesValues);

        return (parsedString, matchesStack);
    }

    private static string PasteTags(string parsedString, Stack<string> tagContents)
    {
        var stringWithTags = parsedString;
        var tagRegex = new Regex(placeholderTagRegex);

        while (tagContents.TryPop(out var tag))
        {
            stringWithTags = tagRegex.Replace(stringWithTags, tag, 1);
        }

        return stringWithTags;
    }

    private const string sourceTagRegex = @"<[^<>]+>";
    private const string placeholderTag = "<$>";
    private const string placeholderTagRegex = @"<\$>";
}
