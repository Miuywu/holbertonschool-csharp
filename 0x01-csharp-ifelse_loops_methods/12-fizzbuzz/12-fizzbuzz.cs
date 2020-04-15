using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 100; a++)
            {
                if (a % 15 == 0)
                    Console.Write("FizzBuzz");
                else if (a % 5 == 0)
                    Console.Write("Buzz");
                else if (a % 3 == 0)
                    Console.Write("Fizz");
                else
                    Console.Write("{0}", a);
                if (a < 100)
                    Console.Write(" ");
                else
                    Console.WriteLine();
            }
        }
    }
}
