using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] ara;
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        ara = new int[size];
        for (int a = 0; a < size; a++)
            ara[a] = a;
        foreach (var ele in ara)
        {
            Console.Write("{0}", ele);
            if (ele != ara[ara.Length - 1])
                Console.Write(" ");
            else
                Console.Write("\n");
        }
        return ara;
    }
}