﻿using System;

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
    //=============================================================================================
    // ==== Constructors ==========================================================================
    //=============================================================================================
    private int width;
    private int height;

    /// <summary>Property Width, must be positive.</summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    /// <summary>Property Height, must be positive.</summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
    //=============================================================================================
    // ==== Methods ===============================================================================
    //=============================================================================================

    ///<summary>This method calculates the area of the Rectangle.</summary>
    public new int Area()
    {
        return (width * height);
    }

    ///<summary>This method overrides the .ToString method.</summary>
    public override string ToString()
    {
        return ($"[Rectangle] {width} / {height}");
    }
}
/// <summary>This is a class Square, it inherits from Rectangle.</summary>
class Square : Rectangle
{
    //=============================================================================================
    // ==== Constructors ==========================================================================
    //=============================================================================================
    private int size;
    
    /// <summary>Property size, must be positive.</summary>
    public int Size
    {
        get { return this.size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
                {
                    this.Height = value;
                    this.Width = value;
                    this.size = value;
                }
        }
    }
    //=============================================================================================
    // ==== Methods ===============================================================================
    //=============================================================================================
    /// <summary>Overides ToString method.</summary>
    public override string ToString()
    {
        return ($"[Square] {size} / {size}");
    }
}
