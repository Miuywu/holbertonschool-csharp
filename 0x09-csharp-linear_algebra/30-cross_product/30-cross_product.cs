using System;
///<summary>Class for VectorMath</summary>
class VectorMath
{
	///<summary>cross product</summary>
	///<return>array or -1</return>
	public static double[] CrossProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length == 3 && vector2.Length == 3)
			return new double[3] {vector1[1] * vector2[2] - (vector1[2] * vector2[1], vector1[2] * vector2[0] - (vector1[0] * vector2[2]), vector1[0] * vector2[1] - (vector1[1] * vector2[0])};
		return new double[] { -1 };
	}
}

