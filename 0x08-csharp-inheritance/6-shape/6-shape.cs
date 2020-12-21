using System;

/// <summary>This is a base class for shapes.</summary>
class Shape
{
    /// <summary>Calculates the area of a shape.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>This is a class Rectangle, it inherits from the Shape Class.</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Property Width, must be positive.</summary>
    public int Width
    {
        get
        {
            return this.width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                this.width = value;
        }
    }
    /// <summary>Property Height, must be positive.</summary>
    public int Height
    {
        get
        {
            return this.height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                this.height = value;
        }
    }
}