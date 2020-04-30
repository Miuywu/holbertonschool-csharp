using System;
using System.Collections.Generic;

class List
{
	public static int SafePrint(List<int> myList, int n)
	{
		int a = 0;

		try
		{
			for (int b = 0; b < n; b++)
			{
				Console.WriteLine(myList[b]);
				a++;
			}

			return a;
		}
		catch
        {
			return a;
        }
	}
}