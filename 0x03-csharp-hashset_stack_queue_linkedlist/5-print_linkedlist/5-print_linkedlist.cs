using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> lin = new LinkedList<int>();

        for (int a = 0; a < size; a++)
        {
            Console.WriteLine(a);
            lin.AddLast(a);
        }
        return lin;
    }
}