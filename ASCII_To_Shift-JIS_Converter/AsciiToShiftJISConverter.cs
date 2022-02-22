using System.Text;

namespace ASCII_To_Shift_JIS_Converter;

internal class ConverterOutput
{
    internal string ShiftJISString { get; set; }
    internal byte[] ShiftJISBytes { get; set; }
}

internal static class AsciiToShiftJISConverter
{
    internal const int amountOfNumbers = 10;
    internal const int amountOfLetters = 26;

    internal const int asciiNumbersIndex = 0x30;
    internal const int asciiUppercaseLettersIndex = 0x41;
    internal const int asciiLowercaseLettersIndex = 0x61;

    internal const int shiftJISNumbersIndex = 0x82f4;
    internal const int shiftJISUppercaseLettersIndex = 0x8260;
    internal const int shiftJISLowercaseLettersIndex = 0x8281;

    internal static ConverterOutput Convert(string asciiString)
    {
        var asciiBytes = asciiString.Select(c => BitConverter.GetBytes(c).First());
        var shiftJISBytes = asciiBytes.SelectMany(b => ConvertToShiftJISBytes(b)).ToArray();
        var shiftJISString = Encoding.GetEncoding("shift_jis").GetString(shiftJISBytes);

        return new ConverterOutput { ShiftJISString = shiftJISString, ShiftJISBytes = shiftJISBytes };
    }

    private static byte[] ConvertToShiftJISBytes(byte asciiByte)
    {
        if (asciiByte is >= asciiNumbersIndex and < (asciiNumbersIndex + amountOfNumbers))
            return BitConverter.GetBytes(shiftJISNumbersIndex + (asciiByte - asciiNumbersIndex));

        if (asciiByte is >= asciiNumbersIndex and < (asciiUppercaseLettersIndex + amountOfNumbers))
            return BitConverter.GetBytes(shiftJISUppercaseLettersIndex + (asciiByte - asciiUppercaseLettersIndex));

        if (asciiByte is >= asciiNumbersIndex and < (asciiLowercaseLettersIndex + amountOfNumbers))
            return BitConverter.GetBytes(shiftJISLowercaseLettersIndex + (asciiByte - asciiLowercaseLettersIndex));

        return new[] { asciiByte };
    }
}
