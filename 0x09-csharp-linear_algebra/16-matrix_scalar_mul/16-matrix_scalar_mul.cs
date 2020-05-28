using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>calcuating applying scalar on matrix</summary>
	///<return>the result matrix or matrix containing -1</return>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
		{
			double[,] result = {
				{matrix[0, 0] * scalar, matrix[0, 1] * scalar},
				{matrix[1, 0] * scalar, matrix[1, 1] * scalar}
			};
			return result;
		}
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double[,] result = {
				{matrix[0, 0] * scalar, matrix[0, 1] * scalar, matrix[0, 2] * scalar},
				{matrix[1, 0] * scalar, matrix[1, 1] * scalar, matrix[1, 2] * scalar},
				{matrix[2, 0] * scalar, matrix[2, 1] * scalar, matrix[2, 2] * scalar}
			};
			return result;
		}
		return new double[,] {{-1}};
	}
}
