using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int a = 0;

        foreach (int b in myLList)
        {
            a += b;
        }

        return a;
    }
}
