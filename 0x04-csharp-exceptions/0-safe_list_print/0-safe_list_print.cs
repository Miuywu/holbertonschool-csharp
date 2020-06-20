using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int size = 0;

        try
        {
            for (int a = 0; a < n; a++, size++)
                Console.WriteLine(myList[a]);
            return size;
        }
        catch (System.Exception)
        {
            return size;
        }
    }
}