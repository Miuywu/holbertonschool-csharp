using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int yum = 0;
        HashSet<int> hash = new HashSet<int>(myList);
        foreach (int browns in hash)
        {
            yum += browns;
        }
        return yum;
    }
}