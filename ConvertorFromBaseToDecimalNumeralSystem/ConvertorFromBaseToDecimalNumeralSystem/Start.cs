using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

internal class Start
{
    internal static void Main()
    {
        // Add numeral system keys.
        List<string> keys = new List<string>();
        keys.Add("KKK0"); // 0
        keys.Add("KKK1"); // 1
        keys.Add("KKK2"); // 2
        keys.Add("KKK3"); // 3
        keys.Add("KKK4"); // 4
        keys.Add("KKK5"); // 5
        keys.Add("KKK6"); // 6
        keys.Add("KKK7"); // 7
        keys.Add("KKK8"); // 8

        string baseNumber = Console.ReadLine();
        ulong convertedNumber = ConvertFromBaseToDecimal(keys, baseNumber);
        Console.WriteLine(convertedNumber);
    }

    internal static ulong ConvertFromBaseToDecimal(List<string> keys, string baseNumber)
    {
        List<ulong> numL = new List<ulong>();
        string currentKey = string.Empty;
        for (int i = 0; i < baseNumber.Length; i++)
        {
            currentKey += baseNumber[i].ToString();
            if (keys.IndexOf(currentKey) > -1)
            {
                numL.Add((ulong)keys.IndexOf(currentKey));
                currentKey = string.Empty;
            }
        }

        ulong[] decimalNumbers = numL.ToArray();
        Array.Reverse(decimalNumbers);
        ulong result = 0;
        for (int i = 0; i < numL.Count; i++)
        {
            result += (decimalNumbers[i] * Pow((ulong)keys.Count, (ulong)i));
        }

        return result;
    }

    internal static ulong Pow(ulong number, ulong pow)
    {
        ulong result = 1;
        for (ulong i = 0; i < pow; i++)
        {
            result *= number;
        }

        return result;
    }
}
