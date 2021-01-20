using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This method multiplies a scalar with a matrix.</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return new double[,] { };

        double[,] newMat = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < newMat.GetLength(0); i++)
        {
            for (int j = 0; j < newMat.GetLength(1); j++)
            {
                newMat[i, j] = matrix[j, i];
            }
        }
        return (newMat);
    }
}

