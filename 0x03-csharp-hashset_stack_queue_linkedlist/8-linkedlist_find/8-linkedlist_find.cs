using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int a = 0;

        foreach (int b in myLList)
        {
            if (b == value)
            {
                return a;
            }

            a++;
        }

        return -1;
    }
}
