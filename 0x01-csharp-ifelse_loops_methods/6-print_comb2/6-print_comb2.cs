using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "\n";
            for (char i = '0'; i <= '9'; i++)
            {
                char b = i++;
                i--;
                for (char j = b; j <= '9'; j++)
                {
                    if (j == i)
                        continue;
                    Console.Write("{0}{1}", i, j);
                    if ((i != '8') || (j != '9'))
                        d = ", ";
                    else
                    {
                        Console.Write("\n");
                        return;
                    }
                    Console.Write(d);
                }
            }
        }
    }
}
