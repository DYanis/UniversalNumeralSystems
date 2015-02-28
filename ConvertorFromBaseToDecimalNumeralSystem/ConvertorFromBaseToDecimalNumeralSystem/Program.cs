using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        List<string> keys = new List<string>();
        // Add here numeral system keys.
        keys.Add("xxx");
        keys.Add("XXX");
        keys.Add("yyy");
        keys.Add("YYY");
        keys.Add("zzz");
        keys.Add("ZZZ");
        keys.Add("JJJ");
        keys.Add("III");
        keys.Add("KKK");


        string number = Console.ReadLine();
        ulong res = ConvertorFromBaseToDecimal(keys, number);
        Console.WriteLine(res);
    }

    static ulong ConvertorFromBaseToDecimal(List<string> keys, string key)
    {        
        List<ulong> numL = new List<ulong>();
        string n = "";
        for (int i = 0; i < key.Length; i++)
        {
            n += key[i].ToString();
            if (keys.IndexOf(n) > -1)
            {
                numL.Add((ulong)keys.IndexOf(n));
                n = "";
            }
        }

        ulong[] decNumbers = numL.ToArray();
        Array.Reverse(decNumbers);
        ulong result = 0;
        for (int i = 0; i < numL.Count; i++)
        {
            result += (ulong)(decNumbers[i] * Math.Pow(keys.Count, i));
        }
        return result;
    }
}