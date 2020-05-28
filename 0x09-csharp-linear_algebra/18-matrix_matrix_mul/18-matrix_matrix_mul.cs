using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>matrix multiplication</summary>
	///<return>the result matrix or error</return>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		if (matrix1.GetLength(1) == matrix2.GetLength(0))
		{
			double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
			for (int a = 0; a < matrix1.GetLength(0); a++)
				for (int b = 0; b < matrix2.GetLength(1); b++)
					for (int c = 0; c < matrix1.GetLength(1); c++)
						result[i, j] += matrix1[i, k] * matrix2[k, j];
			return result;
		}
		return new double[,] {{-1}};
	}
}
