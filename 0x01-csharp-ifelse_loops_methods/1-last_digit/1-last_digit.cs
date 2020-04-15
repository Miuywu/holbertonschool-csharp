using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        string msg = "";
        if (number % 10 > 5)
            msg = "and is greater than 5";
        else if (number % 10 == 0)
            msg = "and is 0";
        else if ((number % 10 < 6) && (number != 0))
            msg = "and is less than 6 and not 0";
	    Console.WriteLine("The last digit of {0} is {1} {2}", number, number % 10, msg);
    }
}