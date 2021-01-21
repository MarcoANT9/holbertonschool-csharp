using System;

/// <summary>This is the class object.</summary>
class VectorMath
{
    /// <summary>This method gets the determinant of a matrix.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 && vector2.Length != 3)
            return new double[] {-1};
        double[] result = new double[3];
        result[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        result[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        result[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];
        foreach (double element in result)
            element = Math.Round(element, 2);
        return (result);
    }
}

