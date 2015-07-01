using System;
using System.Collections.Generic;
using System.Linq;

internal class Start
{
    internal static void Main()
    {
        // Add numeral system keys.
        List<string> keys = new List<string>();
        keys.Add("ZZZ0");
        keys.Add("ZZZ1");
        keys.Add("ZZZ2");
        keys.Add("ZZZ3");
        keys.Add("ZZZ4");
        keys.Add("ZZZ5");
        keys.Add("ZZZ6");
        keys.Add("ZZZ7");

        ulong decimalNumber = ulong.Parse(Console.ReadLine());
        string convertedNumber = ConvertorFromDecimalToBase(keys, decimalNumber);
        Console.WriteLine(convertedNumber);
    }

   internal static string ConvertorFromDecimalToBase(List<string> keys, ulong decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return keys[0];
        }

        string baseNumber = string.Empty;
        while (decimalNumber > 0)
        {
            baseNumber = keys[(int)(decimalNumber % (ulong)keys.Count)] + baseNumber;
            decimalNumber /= (ulong)keys.Count;
        }

        return baseNumber;
    }
}