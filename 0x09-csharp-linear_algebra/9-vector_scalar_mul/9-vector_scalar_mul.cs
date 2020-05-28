using System;
///<summary>Class for VectorMath</summary>
class VectorMath
{
	///<summary>calcuating vector</summary>
	///<return>vector or error</return>
	public static double[] Multiply(double[] vector, double scalar)
	{
		if (vector.Length == 2)
		{
			double[] result = {vector[0] * scalar, vector[1] * scalar};
			return result;
		}
		else if (vector.Length == 3)
		{
			double[] result = {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
			return result;
		}
		return new double[] { -1 };
	}
}
