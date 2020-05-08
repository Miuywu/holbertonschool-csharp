using System;

/// <summary>gets a shape.</summary>
class Shape
{
    /// <summary>gets area.</summary>
    /// <returns>area.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>Rectangle.</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Gets/sets width.</summary>
    /// <value>set value.</value>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value >= 0)
            {
                width = value;
            }
            else
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
        }
    }

    /// <summary>Gets/sets height.</summary>
    /// <value>set value.</value>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value >= 0)
            {
                height = value;
            }
            else
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
        }
    }

    /// <summary>new area of the Rectangle.</summary>
    /// <returns>new area.</returns>
    public new int Area()
    {
        return Height * Width;
    }

    /// <summary>new string representation of the Rectangle.</summary>
    /// <returns>new string representation.</returns>
    public override string ToString()
    {
        return String.Format("[Rectangle] {0} / {1}", Width, Height); 
    }
}


/// <summary>square.</summary>
class Square : Rectangle
{
    private int size;

    /// <summary>Gets/sets size.</summary>
    /// <value>set value.</value>
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value >= 0)
            {
                size = value;
                Height = value;
                Width = value;
            }
            else
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
        }
    }
}