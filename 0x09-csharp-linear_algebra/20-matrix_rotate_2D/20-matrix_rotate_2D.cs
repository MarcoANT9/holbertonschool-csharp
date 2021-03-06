﻿using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This method rotates a matrix angle radians.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (!(matrix is double[,]) || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };
        double[,] matRot = { { 0, 0 }, { 0, 0 } };

        matRot[0, 0] = Math.Round(matrix[0, 0] * Math.Cos(angle) - matrix[0, 1] * Math.Sin(angle), 2);
        matRot[0, 1] = Math.Round(matrix[0, 0] * Math.Sin(angle) + matrix[0, 1] * Math.Cos(angle), 2);
        matRot[1, 0] = Math.Round(matrix[1, 0] * Math.Cos(angle) - matrix[1, 1] * Math.Sin(angle), 2);
        matRot[1, 1] = Math.Round(matrix[1, 0] * Math.Sin(angle) + matrix[1, 1] * Math.Cos(angle), 2);
        return (matRot);

    }
}

