using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        string l = "";
        if (length > 1)
        {
            Console.WriteLine();
            return;
        }
        for (int i = 0; i < length; i++)
        {
            Console.Write(l);
            Console.WriteLine("\\");
            l += " ";
        }
    }
}