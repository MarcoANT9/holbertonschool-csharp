using System;

///<summary>This is the Queue Class.</summary>
public class Queue<T>
{
    ///<summary>This method returns the Queue's type.</summary>
    public Type CheckType()
    {
        return (typeof(T));
    }
}

