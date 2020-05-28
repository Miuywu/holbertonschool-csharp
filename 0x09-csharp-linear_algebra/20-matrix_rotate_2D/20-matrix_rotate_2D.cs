using System;
///<summary>Class for MatrixMath</summary>
class MatrixMath
{
	///<summary>matrix rotation</summary>
	///<return>matrix or -1</return>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		double[,] rotate = {
			{Math.Cos(angle), -Math.Sin(angle)},
			{Math.Sin(angle), Math.Cos(angle)}
		};
		int x = matrix.GetLength(0);
		int y = matrix.GetLength(1);
		if (2 == x)
		{
			double[,] rotted = new double[2, y];
			for (int a = 0; a < x; a++)
				for (int b = 0; b < 2; b++)
					for (int c = 0; c < y; c++)
						rotted[a, b] += Math.Round(rotate[a, c] * matrix[c, b]);
			return rotted;
		}
		return new double[,] {{-1}};
	}
}