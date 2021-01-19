﻿using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] bat_mat = { { -1, -1 }, { -1, -1 } };

        if (
            (matrix1.GetLength(0) != matrix1.GetLength(1)) ||
            (matrix2.GetLength(0) != matrix2.GetLength(1)) ||
            (matrix1.GetLength(0) != matrix2.GetLength(0)) ||
            (matrix1.GetLength(1) != matrix2.GetLength(1))
        )
            return bat_mat;
        int i = 0;
        int j;
        while (i < matrix1.GetLength(0))
        {
            j = 0;
            while(j < matrix1.GetLength(1))
            {
                matrix1[i, j] += matrix2[i, j];
                j++;
            }
            i++;
        }
        return (matrix1);
    }
}
