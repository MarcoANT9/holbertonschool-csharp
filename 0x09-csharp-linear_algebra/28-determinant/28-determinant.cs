using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This method multiplies a scalar with a matrix.</summary>
    public static double Determinant(double[,] matrix)
    {
        if (
            (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3) ||
            (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3) ||
            (matrix.GetLength(0) != matrix.GetLength(1))

        )
            return -1;

        if (matrix.GetLength(0) == 2)
            return (matrix[0, 0] * matrix[1, 1] - (matrix[1, 0] * matrix[0, 1]));
        return (
            (
            matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
            matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
            matrix[1, 0] * matrix[2, 1] * matrix[0, 2]
            ) -
            (
            matrix[2, 0] * matrix[1, 1] * matrix[0, 2] +
            matrix[1, 0] * matrix[0, 1] * matrix[2, 2] +
            matrix[2, 1] * matrix[1, 2] * matrix[0, 0]
            )
        );
    }
}

