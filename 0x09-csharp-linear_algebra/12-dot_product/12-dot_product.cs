using System;

/// <summary>This is the class object.</summary>
class VectorMath
{
    /// <summary>This method gets either a 2D or 3D vector and returns dot product,
    ///if the vector is not 2D or 3D, or the size of the vectors is different it
    ///returns -1.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (
            (vector1.Length > 3 || vector2.Length > 3) ||
            (vector1.Length < 2 || vector2.Length < 2) ||
            (vector1.Length != vector2.Length)
        )
            return (-1);
        
        double sum = 0;

        for (int i = 0; i < vector1.Length; i++)
            sum += vector1[i] * vector2[i];

        return (sum);
    }
}

