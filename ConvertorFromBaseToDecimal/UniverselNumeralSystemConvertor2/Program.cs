using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> keys = new List<string>();
        // Add here numeral system keys
        keys.Add("f");
        keys.Add("bIN");
        keys.Add("oBJEC");
        keys.Add("mNTRAVL");
        keys.Add("lPVKNQ");
        keys.Add("pNWE");
        keys.Add("hT");
        
        string number = Console.ReadLine();
        ulong res = ConvertorFromBaseToDecimal(keys, number);
        Console.WriteLine(res);
    }

    static ulong ConvertorFromBaseToDecimal(List<string> keys, string key)
    {
        string n = "";
        ulong result = 0;
        List<ulong> numL = new List<ulong>();

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

        for (int i = 0; i < numL.Count; i++)
        {
            result += (ulong)(decNumbers[i] * Math.Pow(keys.Count, i));
        }        
        return result;
    }
}

