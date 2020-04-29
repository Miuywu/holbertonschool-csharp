using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int n;

        if (myLList.Count == 0)
        {
            n = 0;
        }
        else
        {
            n = myLList.First.Value;
            myLList.RemoveFirst();
        }
        return val;
    }
}
