using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
		for (LinkedListNode<int> N = myLList.First; N != null; N = N.Next)
		{
			if (n < N.Value)
			{
				return myLList.AddBefore(N, n);
			}
		}

		return myLList.AddLast(n);
    }
}
