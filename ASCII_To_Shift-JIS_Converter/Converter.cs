using System.Text;

namespace ASCII_To_Shift_JIS_Converter;

internal class ConverterOutput
{
    internal string ShiftJISString { get; set; }
    internal byte[] ShiftJISBytes { get; set; }
}

internal static class Converter
{
    internal const int amountOfNumbers = 10;
    internal const int amountOfLetters = 26;

    internal const int asciiNumbersIndex = 0x30;
    internal const int asciiUppercaseLettersIndex = 0x41;
    internal const int asciiLowercaseIndex = 0x61;

    internal const int shiftJISNumbersIndex = 0x82f4;
    internal const int shiftJISUppercaseLettersIndex = 0x8260;
    internal const int shiftJISLowercaseIndex = 0x8281;

    internal static ConverterOutput GetInfo(string asciiString)
    {
        var asciiBytes = asciiString.Select(c => BitConverter.GetBytes(c).First());
        var shiftJISBytes = asciiBytes.SelectMany(b => ConvertToShiftJISBytes(b)).ToArray();
        var shiftJISString = Encoding.GetEncoding("shift_jis").GetString(shiftJISBytes);

        return new ConverterOutput { ShiftJISString = shiftJISString, ShiftJISBytes = shiftJISBytes };
    }

    internal static byte[] ConvertToShiftJISBytes(byte asciiByte)
    {
        if (asciiByte is >= asciiNumbersIndex and < (asciiNumbersIndex + amountOfNumbers))
            return BitConverter.GetBytes(shiftJISNumbersIndex + (asciiByte - asciiNumbersIndex));

        if (asciiByte is >= asciiNumbersIndex and < (asciiNumbersIndex + amountOfNumbers))
            return BitConverter.GetBytes(shiftJISUppercaseLettersIndex + (asciiByte - asciiUppercaseLettersIndex));

        if (asciiByte is >= asciiNumbersIndex and < (asciiNumbersIndex + amountOfNumbers))
            return BitConverter.GetBytes(shiftJISLowercaseIndex + (asciiByte - asciiLowercaseIndex));

        return new[] { asciiByte };
    }
}
