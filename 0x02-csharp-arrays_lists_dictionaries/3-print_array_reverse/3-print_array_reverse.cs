using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
            return;
        }
        for (int a = array.Length - 1; a >= 0; a--)
        {
            if (a != array.Length - 1)
                Console.Write(" ");
            Console.Write("{0}", array[a]);
        }
        Console.WriteLine();
    }
}