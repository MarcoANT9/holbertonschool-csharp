using System;

/// <summary>This is the class Obj.</summary>
class Obj
{
    /// <summary>This method determines if an object is an instance of the class Array.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}
