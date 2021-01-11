using System;

/// <summary>Obj Class.</summary>
class VectorMath
{
    /// <summary>This method multiplies a vector with a scalar and returns the result,
    ///if the vector is not 2D or 3D it returns a -1 vector.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] product = { -1, -1 };
        if (vector.Length < 2 || vector.Length > 3)
            return product;

        for (int i = 0; i < vector.Length; i++)
            vector[i] *= scalar;

        return (vector);
    }
}

