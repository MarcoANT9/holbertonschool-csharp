using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This method multiplies a scalar with a matrix.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (
            (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3) &&
            (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
        )
            return (new double [,] {{-1}});
        
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] *= scalar;
        return (matrix);
    }
}

