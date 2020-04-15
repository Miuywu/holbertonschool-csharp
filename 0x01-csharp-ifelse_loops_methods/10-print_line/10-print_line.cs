using System;

class Line
{
    public static void PrintLine(int length)
    {
        string l = "";
        for (int i = 0; i < length; i++)
            l += l;
        Console.WriteLine(l);
    }
}