using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This method sums two 2D or 3D matrices.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] bat_mat = { { -1, -1 }, { -1, -1 } };

        if (
            (matrix1.GetLength(0) != matrix1.GetLength(1)) ||
            (matrix2.GetLength(0) != matrix2.GetLength(1)) ||
            (matrix1.GetLength(0) != matrix2.GetLength(0)) ||
            (matrix1.GetLength(1) != matrix2.GetLength(1)) ||
            (matrix1.GetLength(0) != 2 || matrix1.GetLength(0) != 3) ||
            (matrix2.GetLength(0) != 2 || matrix2.GetLength(0) != 3) ||
            (matrix1.GetLength(1) != 2 || matrix1.GetLength(1) != 3) ||
            (matrix2.GetLength(1) != 2 || matrix2.GetLength(1) != 3)

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

