using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> liz = new List<string>();
        foreach (string key in myDict.Keys)
            liz.Add(key);
        liz.Sort();
        foreach (string key in liz)
            Console.WriteLine("{0}: {1}", key, myDict[key]);
    }
}
