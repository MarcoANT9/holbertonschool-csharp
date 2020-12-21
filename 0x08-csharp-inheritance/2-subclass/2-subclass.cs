using System;

/// <summary>This is the class Obj.</summary>
class Obj
{
    /// <summary>This method determines if an object is an instance of a class
    /// that inherits from the specified class; the object must be a subclass.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}

