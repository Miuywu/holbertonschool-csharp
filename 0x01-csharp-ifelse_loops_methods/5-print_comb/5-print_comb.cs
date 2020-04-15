using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "";
            for (int i = 0; i <= 99; i++)
            {
                Console.Write("{0:00}", i);
                if (i != 99)
                    d = ", ";
                else
                    d = ", \n";
                Console.Write(d);
            }
        }
    }
}
