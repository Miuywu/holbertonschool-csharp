using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> N = myLList.First;

		if ((index < 0) || (index >= myLList.Count))
		{
			return;
		}

		for (int a = 0; a < index; a++, N = N.Next)
            ;

		myLList.Remove(N);
    }
}
