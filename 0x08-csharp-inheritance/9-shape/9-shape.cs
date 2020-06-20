using System;

///<summary>Shapes</summary>
class Shape
{
	//error method is not modified
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}

///<summary>Class Rectangle</summary>
class Rectangle : Shape
{
	private int width;
	private int height;

	//width
	public int Width
	{
		get
		{
			return width;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Width must be greater than or equal to 0");
			}
			width = value;
		}
	}

	//height
	public int Height
	{
		get
		{
			return height;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Height must be greater than or equal to 0");
			}
			height = value;
		}
	}

	//return Area
	public new int Area()
	{
		return width * height;
	}

	//overide string method
	public override string ToString()
	{
		return String.Format("[Rectangle] {0} / {1}", width, height);
	}
}


///<summary>Class Rectangle</summary>
class Square : Rectangle
{
	private int size;

	//size of width and height
	public int Size
	{
		get
		{
			return size;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Size must be greater than or equal to 0");
			}
			size = value;
			Height = value;
			Width = value;
		}
	}

	public override string ToString()
	{
		return String.Format("[Square] {0} / {0}", size);
	}
}