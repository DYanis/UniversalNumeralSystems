using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

internal class Start
{
    internal static void Main()
    {
        List<string> keys = new List<string>();

        // Add here numeral system keys.
        keys.Add("ZZZ");
        keys.Add("ZZZ");
        keys.Add("ZZZ");
        keys.Add("ZZZ");
        keys.Add("ZZZ");
        keys.Add("ZZZ");
        keys.Add("ZZZ");
        keys.Add("ZZZ");
        keys.Add("ZZZ");

        string number = Console.ReadLine();
        ulong convertedNumber = ConvertorFromBaseToDecimal(keys, number);
        Console.WriteLine(convertedNumber);
    }

    internal static ulong ConvertorFromBaseToDecimal(List<string> keys, string key)
    {
        List<ulong> numL = new List<ulong>();
        string n = string.Empty;
        for (int i = 0; i < key.Length; i++)
        {
            n += key[i].ToString();
            if (keys.IndexOf(n) > -1)
            {
                numL.Add((ulong)keys.IndexOf(n));
                n = string.Empty;
            }
        }

        ulong[] decNumbers = numL.ToArray();
        Array.Reverse(decNumbers);
        ulong result = 0;
        for (int i = 0; i < numL.Count; i++)
        {
            result += (decNumbers[i] * Pow((ulong)keys.Count, (ulong)i));
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
