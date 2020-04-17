using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ara = new int[5, 5];
            ara[2, 2] = 1;
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    Console.Write("{0}", ara[a, b]);
                    if (b != 4)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
