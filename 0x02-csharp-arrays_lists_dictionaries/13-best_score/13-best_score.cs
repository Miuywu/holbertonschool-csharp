using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return null;
        int m = Int32.MinValue;
        string k = "";
        foreach (string key in myList.Keys)
        {
            if (m < myList[key])
            {
                m = myList[key];
                k = key;        
            }        
        }
        return k;
    }
}