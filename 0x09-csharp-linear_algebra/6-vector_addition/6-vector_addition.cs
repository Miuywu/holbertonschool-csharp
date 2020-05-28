using System;
///<summary>Class for VectorMath</summary>
class VectorMath
{
	///<summary>vector add</summary>
	///<return>the result vector or error</return>
	public static double[] Add(double[] vector1, double[] vector2)
	{
		if (vector1.Length == 2 && vector2.Length == 2)
		{
			double[] sum = {vector1[0] + vector2[0], vector1[1] + vector2[1]};
			return sum;
		}
		else if (vector1.Length == 3 && vector2.Length == 3)
		{
			double[] sum = {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
			return sum;
		}
		return new double[] {-1};
	}
}