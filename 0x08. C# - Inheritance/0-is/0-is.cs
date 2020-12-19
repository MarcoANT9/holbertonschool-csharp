using System;

/// <summary>This is the class Obj.</summary>
class Obj
{
    /// <summary>This method determines if an object is an instance of the class int.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        return false;
    }
}

