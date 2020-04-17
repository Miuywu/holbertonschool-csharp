using System;
class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
		int[,] ara = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
		for (int a = 0; a < myMatrix.GetLength(0); a++)
			for (int b = 0; b < myMatrix.GetLength(1); b++)
				ara[a, b] = myMatrix[a, b] * myMatrix[a, b];
		return ara;
    }
}