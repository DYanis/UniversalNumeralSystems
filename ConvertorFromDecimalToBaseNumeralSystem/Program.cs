using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> keys = new List<string>();
        keys.Add("LON+");
        keys.Add("VK-");
        keys.Add("*ACAD");
        keys.Add("^MIM");
        keys.Add("ERIK|");
        keys.Add("SEY&");
        keys.Add("EMY>>");
        keys.Add("/TEL");
        keys.Add("<<DON");


        ulong number = ulong.Parse(Console.ReadLine());
        string res = ConvertorFromDecimalBase(keys, number);
        Console.WriteLine(res);
    }

    static string ConvertorFromDecimalBase(List<string> keys, ulong decimalNum)
    {
        if (decimalNum == 0)
        {
            return keys[0];
        }

        string res = "";
        while (decimalNum > 0)
        {
            res = keys[(int)(decimalNum % (ulong)keys.Count)] + res;
            decimalNum /= (ulong)keys.Count;
        }
        return res;
    }
}