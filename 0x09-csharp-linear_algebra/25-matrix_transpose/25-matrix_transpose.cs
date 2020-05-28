using System;


///<summary>Class for MatrixMath</summary>
class MatrixMath
{
	///<summary>matrix transposing</summary>
	///<return>matrix or empty</return>
	public static double[,] Transpose(double[,] matrix)
	{
		double[,] trans = new double[matrix.GetLength(1), matrix.GetLength(0)];

		for (int a; a < matrix.GetLength(1); a++)
			for (int b; b < matrix.GetLength(0); b++)
				trans[b][a] = matrix[a][b];
		return matrix;
	}
}
