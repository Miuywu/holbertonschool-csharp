using System;
using System.Collections.Generic;
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> N;

        if (n < 0 || n > myLList.Count - 1)
        {
            return 0;
        }
        for (N = myLList.First; n > 0; N = N.Next, n--)
            ;

        return N.Value;
    }
}