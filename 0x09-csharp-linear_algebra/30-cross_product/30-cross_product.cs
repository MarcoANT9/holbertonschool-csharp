using System;

/// <summary>This is the class object.</summary>
class VectorMath
{
    /// <summary>This method gets the determinant of a matrix.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] result = {-1, -1, -1};
        if (vector1.Length != 3 || vector2.Length != 3)
            return result;
        
        result[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        result[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        result[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];
        
        for (int i = 0; i < 3; i++)
            result[i] = Math.Round(result[i], 2);
        return (result);
    }
}

