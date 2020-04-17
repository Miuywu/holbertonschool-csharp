using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> liz;
        if (myList == null)
            return null;
        liz = new List<bool>();
        for (int a = 0; a < myList.Count; a++)
        {
            if (myList[a] % 2 == 0)
                liz.Add(true);
            else
                liz.Add(false);
        }
        return liz;
    }
}
