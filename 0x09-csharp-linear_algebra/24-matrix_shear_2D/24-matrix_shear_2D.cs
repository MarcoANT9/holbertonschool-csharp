using System;


class MatrixMath
{
    /// <summary>This method shears a matrix in a direction given a factor.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };


        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        if (direction == 'x')
        {
            result[0, 0] = Math.Round(matrix[0, 0] + factor * matrix[0, 1], 2);
            result[1, 0] = Math.Round(matrix[1, 0] + factor * matrix[1, 1], 2);
            result[0, 1] = Math.Round(matrix[0, 1], 2);
            result[1, 1] = Math.Round(matrix[1, 1], 2);
            return (result);
        }
        else if (direction == 'y')
        {
            result[0, 0] = Math.Round(matrix[0, 0], 2);
            result[1, 0] = Math.Round(matrix[1, 0], 2);
            result[0, 1] = Math.Round(matrix[0, 1] + factor * matrix[1, 1], 2);
            result[1, 1] = Math.Round(matrix[1, 1] + factor * matrix[0, 1], 2);
            return (result);
        }
        else
            return (new double[,] {{-1}});
    }
}

