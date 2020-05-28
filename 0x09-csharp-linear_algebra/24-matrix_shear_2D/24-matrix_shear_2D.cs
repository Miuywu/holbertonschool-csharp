using System;

///<summary>Class for MatrixMath</summary>
class MatrixMath
{
	///<summary>sheer matrix</summary>
	///<return>matrix or -1</return>
	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		if (matrix.GetLength(0) != 2 || direction != 'x' || direction != 'y')
			return new double[,] {{-1}};
		if (direction != 'x')
			double[,] shear = new double[,] {{1, factor},{0, 1}};
		else if (direction != 'x')
			double[,] shear = new double[,] {{1, 0},{factor, 1}};
		double[,] result = new double[m1_row, m2_col];
		for (int a = 0; a < 2; a++)
			for (int b = 0; b < 2; b++)
				for (int c = 0; c < 2; c++)
					result[a, b] += shear[a, c] * matrix[c, b];
		return result;
	}
}
