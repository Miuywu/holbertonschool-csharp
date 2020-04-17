using System;
using System.Collections.Generic;
class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> liz;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        liz = new List<int>();
        for (int a = 0; a < size; a++)
        {
            liz.Add(a);
            Console.Write("{0}", a);
            if (a != size - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
        return liz;
    }
}